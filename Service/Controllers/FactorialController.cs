using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Controllers
{
    public class FactorialController
    {
        public static void GetFactorial()
        {

            IFactorialService factorialService = new FactorialService();
            int a = int.Parse(Console.ReadLine());
            factorialService.CalculateFactorial(a);

        }
    }
}
