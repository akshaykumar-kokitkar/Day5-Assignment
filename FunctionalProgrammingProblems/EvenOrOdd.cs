using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    class EvenOrOdd
    {
        int number;
        public void EvenOrOddCheck(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(" {0} is even number", number);
            }
            else
            {
                Console.WriteLine("{0} is is odd number", number);
            }
        }
        
    }
}
