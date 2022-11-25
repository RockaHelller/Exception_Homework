using Domain.Models;
using Service.Service.Exceptions;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class AccountService : IAccountService
    {
        public User GetUserByID(int id)
        {
            List<User> users = new List<User>();

            users.Add(new User { Id = 1, Username = "test1", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 2, Username = "test2", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 3, Username = "test3", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 4, Username = "test4", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 5, Username = "test5", Email = "test@gmail.com", Password = "12345" });


            var result = users.Find(m=>m.Id == id);

            if (result == null)
            {
                throw new NotFoundException();
            }

            return result;

        }

        public bool Register(User user)
        {
            if (user.Email != null)
            {
                if (!user.Email.Contains("@"))
                {
                    return false;
                }

            }

            return true;
        
            
        }

    }
}
