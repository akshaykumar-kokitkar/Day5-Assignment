using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public class Factors
    {
        //prime factors
        //  of a given number n
        public void primeFactors(int n)
        {
            // Print the number of 2s that divide n
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can
            for (int i = 3; (i * i) <= n; i += 2)
            {

                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            // n is a prime number greater than 2
            if (n > 2)
            {
                Console.Write(n);
            }

        }
    }
}



