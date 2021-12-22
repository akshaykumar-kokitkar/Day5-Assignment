using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    class VowelsAndConsonant
    {
        string Alphabet;
        String alpha;

        public void Check(string Alphabet)
        {
            string alpha = Alphabet.ToUpper();
            if (alpha == "A" || alpha == "E" || alpha == "I" || alpha == "O" || alpha == "U")
            {
                Console.WriteLine("This is Vowel");
            }
            else
            {
                Console.WriteLine("This is Consonant");

            }

        }
    }
}