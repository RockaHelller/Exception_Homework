using Domain.Models;
using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Controllers
{
    public class UserController
    {
        public static void Register()
        {
            try
            {
                IAccountService service = new AccountService();

                Console.WriteLine("Add username");
                string? username = Console.ReadLine();

                Console.WriteLine("Add email");
                string? email = Console.ReadLine();

                if (!email.Contains("@"))
                {
                    throw new Exception("Email doesnt have @ symbol");
                }

                Console.WriteLine("Add password");
                string? password = Console.ReadLine();


                User newUser = new()
                {
                    Username = username,
                    Email = email,
                    Password = password
                };

                var result = service.Register(newUser);

                if (!result) throw new Exception("Email doesnt have @ symbol");
               

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public static void GetUserById() 
        {
            try
            {
                IAccountService service = new AccountService();
                var result = service.GetUserByID(7);
                Console.WriteLine(result.Username);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
