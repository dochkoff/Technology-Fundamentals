using System;

namespace P02_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int divider = 0;
            int dividerBigger = 0;

            if (number % 2 == 0)
            {
                divider = 2;
                dividerBigger = divider;
            }
            if (number % 3 == 0)
            {
                divider = 3;
                dividerBigger = divider;
            }
            if (number % 6 == 0)
            {
                divider = 6;

                if (divider > dividerBigger)
                {
                    dividerBigger = divider;
                }
            }
            if (number % 7 == 0)
            {
                divider = 7;

                if (divider > dividerBigger)
                {
                    dividerBigger = divider;
                }
            }
            if (number % 10 == 0)
            {
                divider = 10;

                if (divider > dividerBigger)
                {
                    dividerBigger = divider;
                }
            }

            if (dividerBigger == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {dividerBigger}");
            }
        }
    }
}
