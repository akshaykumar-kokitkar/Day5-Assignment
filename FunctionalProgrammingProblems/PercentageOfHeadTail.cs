using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public class PercentageOfHeadTail
    {
        //constants
        public const int HEAD = 0;
        public const int TAIL = 1;

        public void FlipCoin()
        {
            //variables
            int n = 1;

            //int h = 0;
            //int t = 0;

            int headPercentage = 100;
            int tailPercentage = 100;

            int NO_OF_HEAD = 0;
            int NO_OF_TAIL = 0;

            //compuatation
            Random random = new Random();
            while (n <= 10)
            {
                int check = random.Next(0, 2);
                if (check == HEAD)
                {
                    NO_OF_HEAD = NO_OF_HEAD + 1;
                }
                else
                {
                    NO_OF_TAIL = NO_OF_TAIL + 1;
                }
                n++;

                // NO_OF_HEAD = h;
                // NO_OF_TAIL = t;

                headPercentage = (NO_OF_HEAD * 100) / 10;
                tailPercentage = (NO_OF_TAIL * 100) / 10;
            }
            Console.WriteLine("Head Percentage : " + headPercentage);
            Console.WriteLine("Tail Percenatge : " + tailPercentage);

        }
    }
}
