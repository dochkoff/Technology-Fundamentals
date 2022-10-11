using System;
using System.Linq;

namespace P11_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            double result = Calculate(number1, @operator, number2);

            Console.WriteLine(result);
        }

        private static double Calculate(int number1, string @operator, int number2)
        {
            double calculation = 0;

            switch (@operator)
            {
                case "/":
                    calculation = number1 / number2;
                    break;
                case "*":
                    calculation = number1 * number2;
                    break;
                case "+":
                    calculation = number1 + number2;
                    break;
                case "-":
                    calculation = number1 - number2;
                    break;
            }

            return calculation;
        }
    }
}
