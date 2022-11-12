using System;

namespace P01_BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int binarydigit = int.Parse(Console.ReadLine());

            int counter = 0;

            while (number > 0)
            {
                if (number % 2 == binarydigit)
                {
                    counter++;
                }

                number /= 2;
            }

            Console.WriteLine(counter);
        }
    }
}