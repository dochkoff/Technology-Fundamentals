using System;

namespace P08_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factNum1 = Factorial(num1);
            double factNum2 = Factorial(num2);
            double result = factNum1 / factNum2;

            Console.WriteLine($"{result:F2}");
        }

        static double Factorial(double number)
        {
            double fact = 1;


            for (double i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
