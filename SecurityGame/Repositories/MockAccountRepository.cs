using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecurityGame.Repositories
{
    public class MockAccountRepository : IAccountRepository
    {
        private List<Account> accounts;

        public MockAccountRepository()
        {
            accounts = new List<Account>()
            {
                new Account()
                {
                    ID = 1,
                    Username = "ValidUsername",
                    Password = "$2a$10$eSr8H29et8IZAzqWEcOWlO0iKo0vLNm1EC8CZF8m5aNx0DJi1fcJW", // ValidPassword
                    Role = Enums.Role.Player
                },
                new Account()
                {
                    ID = 4,
                    Username = "Admin",
                    Password = "$2a$10$3Dlibc2FXTZi5NbuZt1fV.mdEXHh2oPaYzkm3MMhS5RPHX2A7kqVS", // AdminPassword
                    Role = Enums.Role.Admin
                }
            };
        }

        public void CreateAccount(Account account) 
            => accounts.Add(account);

        public Account GetAccount(int id) 
            => accounts.Where(a => a.ID == id).FirstOrDefault();

        public Account GetAccount(string username) 
            => accounts.Where(a => a.Username.Equals(username, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
    }
}
