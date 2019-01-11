using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using System.Timers;
using BCr = BCrypt.Net.BCrypt;

namespace SecurityGame.Services
{
    public class AuthService
    {
        public const int MAX_LOGIN_ATTEMPTS = 3;
        public const int LOGIN_COOLDOWN_MILLISECONDS = 5000;

        public bool CooldownActive { get; private set; }

        private int _loginAttempts;
        private Timer _timer;
        private Account _account;
        private readonly IAccountRepository _accountRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthService"/> class.
        /// </summary>
        /// <param name="accountRepository">The account repository.</param>
        public AuthService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            ResetLoginAttempts();
            CooldownActive = false;
        }

        /// <summary>
        /// Checks to see if the username and password match an entry 
        /// in the database.
        /// </summary>
        /// <param name="username">The input username.</param>
        /// <param name="password">The input, plain-text password.</param>
        /// <returns>Whether the login was successful.</returns>
        public bool Login(string username, string password)
        {
            if (HasExceededMaxLoginAttempts())
            {
                OnExceededMaxLoginAttempts();
                return false;
            }
            
            var account = _accountRepository.GetAccount(username);

            if ((account != null) && BCr.Verify(password, account.Password))
            {
                _account = account;
                return true;
            }

            _loginAttempts++;
            return false;         
        }

        /// <summary>
        /// Check if the login attempts exceed the specified max 
        /// login attempts.
        /// </summary>
        /// <returns>Whether there have been too many login attempts.</returns>
        public bool HasExceededMaxLoginAttempts() => _loginAttempts >= MAX_LOGIN_ATTEMPTS;

        /// <summary>
        /// Reset the amount of login attempts made.
        /// </summary>
        public void ResetLoginAttempts() => _loginAttempts = 0;

        /// <summary>
        /// Check if the user has logged in.
        /// </summary>
        /// <returns>Whether the user is logged in.</returns>
        public bool UserIsLoggedIn() => _account != null;

        /// <summary>
        /// Check if the user has the administrator role.
        /// </summary>
        /// <returns>Whether the user is an admin.</returns>
        public bool UserIsAdmin() => (UserIsLoggedIn() && _account.Role == Enums.Role.Admin);

        /// <summary>
        /// Called when the max login attempts limit has been reached.
        /// </summary>
        private void OnExceededMaxLoginAttempts()
        {
            _timer = new Timer();
            _timer.Elapsed += (sender, e) => OnCooldownTimerElapsed(sender, e);
            _timer.Interval = LOGIN_COOLDOWN_MILLISECONDS;
            _timer.Enabled = true;
            CooldownActive = true;
        }

        /// <summary>
        /// Called when the max login attempts cooldown timer has elapsed.
        /// </summary>
        private void OnCooldownTimerElapsed(object sender, ElapsedEventArgs e)
        {
            ResetLoginAttempts();
            _timer.Enabled = false;
            _timer.Dispose();
            CooldownActive = false;
        }
    }
}
