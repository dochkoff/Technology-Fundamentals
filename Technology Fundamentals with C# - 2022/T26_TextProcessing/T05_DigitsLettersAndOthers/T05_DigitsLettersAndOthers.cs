using System;
using System.Collections.Generic;
using System.Linq;

namespace T05_DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits += input[i];
                }

                if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }

                if (!char.IsLetterOrDigit(input[i]))
                {
                    others += input[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}