using System;

namespace P03_FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double substraction = Math.Abs(numberA - numberB);
            if (substraction>=eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
