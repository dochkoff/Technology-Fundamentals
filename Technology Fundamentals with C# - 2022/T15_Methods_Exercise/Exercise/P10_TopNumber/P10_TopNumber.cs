using System;
using System.Linq;

namespace P10_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumberRange = int.Parse(Console.ReadLine());

            for (int i = 1; i < lastNumberRange; i++)
            {
                string number = i.ToString();

                int[] numbers = new int[number.Length];

                for (int k = 0; k < number.Length; k++)
                {
                    numbers[k] = number[k] - '0';
                }

                if (DevideByEight(numbers) && LeastOneOdd(numbers))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool LeastOneOdd(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool DevideByEight(int[] numbers)
        {
            int numbersSum = numbers.Sum();

            if (numbersSum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
