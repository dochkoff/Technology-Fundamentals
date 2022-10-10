using System;

namespace P01_SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOfIntegerNumbers(int.Parse(Console.ReadLine()));

            static void SignOfIntegerNumbers(int number)
            {
                if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else if (number == 0)
                {
                    Console.WriteLine($"The number {number} is zero.");
                }
                else if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
            }
        }
    }
}
