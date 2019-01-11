using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using System.Diagnostics;
using System.Linq;

namespace SecurityGame.Repositories
{
    public class EfAccountRepository : IAccountRepository
    {
        /// <summary>
        /// Add a new account to the database.
        /// </summary>
        /// <param name="account">The new account to be added.</param>
        public void CreateAccount(Account account)
        {
            using (var context = new GameContext())
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get an account by the account ID
        /// </summary>
        /// <param name="id">The account ID</param>
        /// <returns>An account</returns>
        public Account GetAccount(int id)
        {
            using (var context = new GameContext())
                return context.Accounts.Where(a => a.ID == id).FirstOrDefault();
        }

        /// <summary>
        /// Get an account by the account username
        /// </summary>
        /// <param name="username">The account username</param>
        /// <returns>An account</returns>
        public Account GetAccount(string username)
        {
            Debug.Print(username);
            using (var context = new GameContext())
                return context.Accounts.FirstOrDefault(a => a.Username.ToUpper().Equals(username.ToUpper()));
        }
    }
}
