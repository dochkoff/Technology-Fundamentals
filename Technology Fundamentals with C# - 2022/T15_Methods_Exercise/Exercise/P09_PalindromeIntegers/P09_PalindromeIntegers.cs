using System;

namespace P09_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Palindrome(input);
                input = Console.ReadLine();
            }
        }

        private static void Palindrome(string input)
        {
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = input[i] - '0';
            }

            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
