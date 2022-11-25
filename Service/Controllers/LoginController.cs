using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Controllers
{
    public class LoginController
    {
        public static void LoginValidation()
        {
            ILoginService login = new LoginService();

            Console.WriteLine("Username daxil edin");
            string? username = Console.ReadLine();    
            

            Console.WriteLine("Email daxil edin");
            string? email = Console.ReadLine();    


            Console.WriteLine("Password daxil edin");
            string? password = Console.ReadLine();    
            

            login.CheckLogin(username, email, password);
        
        }
    }
}
