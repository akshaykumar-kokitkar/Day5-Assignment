using System;

namespace FunctionalProgrammingProblems
{
    public class LeapYear
    {
        //method to find leap year or not
        public void IsLeapYear (int year)
        {
            //int year;
            //computation
            if ((year % 400 == 0) && (year % 100 != 0) || (year % 4 == 0))
            {
                Console.WriteLine(" {0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }

}