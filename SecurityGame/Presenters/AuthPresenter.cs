using SecurityGame.Constants;
using SecurityGame.Extensions;
using SecurityGame.Services;
using SecurityGame.Views;
using SecurityGame.Views.Interfaces;

namespace SecurityGame.Presenters
{
    public class AuthPresenter : Presenter
    {
        private readonly AuthService _authService;
        private readonly IAuthView _authView;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthPresenter"/> class.
        /// </summary>
        /// <param name="parentPresenter">The parent presenter.</param>
        /// <param name="authService">The authentication service.</param>
        /// <param name="authView">The authentication view.</param>
        public AuthPresenter(
            ParentView parentView,
            AuthService authService,
            IAuthView authView) : base(parentView)
        {
            _authService = authService;
            _authView = authView;

            _authView.Presenter = this;
        }

        /// <summary>
        /// Process the login for the user. Called when the user 
        /// clicks the login button on the view.
        /// </summary>
        public bool Login()
        {
            _authView.Error = "";

            if (_authService.CooldownActive)
            {
                _authView.Error = Messages.LOGIN_TOO_MANY_ATTEMPTS;
                return false;
            }

            if (!CheckLoginDetails()) return false;

            if (_authService.Login(_authView.Username, _authView.Password))
            {
                ShowMenu();
                return true;
            }              

            if (_authService.HasExceededMaxLoginAttempts())
                _authView.Error = Messages.LOGIN_TOO_MANY_ATTEMPTS;
            else
                _authView.Error = Messages.LOGIN_INCORRECT;

            return false;
        }

        /// <summary>
        /// Check the username and password to ensure they are not empty 
        /// and that the username only contains numbers or letters.
        /// </summary>
        /// <returns>Whether the username and password meet requirements.</returns>
        private bool CheckLoginDetails()
        {
            if (_authView.Username.Length <= 0 || _authView.Password.Length <= 0)
            {
                _authView.Error = Messages.LOGIN_EMPTY;
                return false;
            }

            if (!_authView.Username.ContainsOnlyLettersOrNumbers())
            {
                _authView.Error = Messages.LOGIN_ILLEGAL_CHARS;
                return false;
            }

            return true;
        }
    }
}
