using System;
using System.Linq;

namespace P10_MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int absInput = Math.Abs(int.Parse(input));

            int sumOfEvenDigits = GetSumOfEvenDigits(absInput.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absInput.ToString());

            int multipleOfEvenAndOdds = sumOfEvenDigits * sumOfOddDigits;

            Console.WriteLine(multipleOfEvenAndOdds);
        }

        private static int GetSumOfOddDigits(string input)
        {
            int oddSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int oddNumber = int.Parse(input[i].ToString());
                if (oddNumber % 2 != 0)
                {
                    oddSum += oddNumber;
                }
            }

            return oddSum;
        }

        private static int GetSumOfEvenDigits(string input)
        {
            int evenSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int evenNumber = int.Parse(input[i].ToString());
                if (evenNumber % 2 == 0)
                {
                    evenSum += evenNumber;
                }
            }

            return evenSum;
        }
    }
}
