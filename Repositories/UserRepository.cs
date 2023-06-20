using ApiAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() {Id = 1, Username = "batman", Password = "123", Role = "manager"},
                new() {Id = 1, Username = "robin", Password = "123", Role = "manager"},
            };
            return users
                    .FirstOrDefault(x => 
                    x.Username == username
                    && x.Password == password);
        }
    }
}