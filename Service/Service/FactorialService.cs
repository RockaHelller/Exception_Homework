using Service.Service.Exceptions;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class FactorialService : IFactorialService
    {
        public void CalculateFactorial(int a)
        {
			try
			{
                int sum = 1;
                if (a < 0)
                {
                    throw new FactorialNegativeNumException("Zehmet olmasa duzgun reqem daxil edin");
                }
                for (int i = 1; i <= a; i++)
                {
                    sum *= i;
                }
                Console.WriteLine(sum);

            }
            catch (Exception ex)
			{   
                Console.WriteLine(ex.Message);
			}
        }
    }
}
