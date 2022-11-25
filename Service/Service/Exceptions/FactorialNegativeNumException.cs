using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Exceptions
{
    public class FactorialNegativeNumException : Exception
    {
        public FactorialNegativeNumException(string num) : base(num)
        {
        }
    }
}
