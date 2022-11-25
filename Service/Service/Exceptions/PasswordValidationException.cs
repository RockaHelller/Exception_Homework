using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Exceptions
{
    public class PasswordValidationException : Exception
    {
        public PasswordValidationException(string password) : base(password)
        {

        }
    }
}
