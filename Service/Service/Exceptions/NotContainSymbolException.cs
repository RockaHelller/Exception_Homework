using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Exceptions
{
    public class NotContainSymbolException : Exception
    {
        public NotContainSymbolException(string email) : base(email)
        {
        }
    }
}
