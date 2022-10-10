using System;

namespace P03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            //add, multiply, subtract, divide
            if (command == "add")
            {
                Add(number1, number2);
            }
            else if (command == "multiply")
            {
                Multiply(number1, number2);
            }
            else if (command == "substract")
            {
                Substract(number1, number2);
            }
            else if (command == "divide")
            {
                Divide(number1, number2);
            }
        }

        private static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        private static void Substract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        private static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        private static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }

    }
}