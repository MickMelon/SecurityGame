using SecurityGame.Models;

namespace SecurityGame.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Account GetAccount(int id);
        Account GetAccount(string username);
        void CreateAccount(Account account);
    }
}
