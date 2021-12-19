using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public class TableOfPowerOf2
    {
        //method to print table of power of 2
        public double PowerOf2(int n)
        {
            //variable
            double power = 0;

            //computation
            Console.WriteLine("Power of 2");
            for (int i = 1; i <= n; i++)
            {
                  power = Math.Pow(2, i);
              
                Console.WriteLine("{0}", power);  
            }
            return power;
        }
    }
}
