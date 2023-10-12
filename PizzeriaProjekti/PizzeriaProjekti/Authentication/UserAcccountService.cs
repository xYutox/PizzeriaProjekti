﻿namespace PizzeriaProjekti.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount{ UserName = "admin", Password = "admin", Role = "Administrator" },
                new UserAccount{UserName = "user", Password = "user", Role = "user" },
            };
        }

        public UserAccount? GetByUserName(string username)
        {
            return _users.FirstOrDefault(x => x.UserName == username);
        }
    }
}