using Service.Service.Exceptions;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Service
{
    public class LoginService : ILoginService
    {
        public void CheckLogin(string username, string email, string password)
        {
			try
			{
                if (username.Length < 6)
                {
                    throw new MinimumNumException("Minimum 6 elementden ibaret olmalidir");
                }
                else if (!email.Contains("@"))
				{
					throw new NotContainSymbolException("Email-de @ isaresi olmalidi");
				}
				else if (!(Regex.IsMatch(password, @"[0-9]") && Regex.IsMatch(password, @"[A-Z]")))
				{
					throw new PasswordValidationException("Sifrede reqem olmalidir ve ilk Herf boyuk olmalidir");
				}
				else
				{
					Console.WriteLine("Giris Ugurludur!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
    }
}
