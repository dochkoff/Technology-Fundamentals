using System;
using System.Linq;

namespace P09_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (type == "int")
            {
                int number1 = int.Parse(input1);
                int number2 = int.Parse(input2);
                int result = GetMax(number1, number2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char char1 = char.Parse(input1);
                char char2 = char.Parse(input2);
                char result = GetMax(char1, char2);
                Console.WriteLine(result);
            }
            else
            {
                string result = GetMax(input1, input2);
                Console.WriteLine(result);
            }
        }

        private static string GetMax(string input1, string input2)
        {
            int result = input1.CompareTo(input2);

            if (result > 0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }

        private static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        private static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
    }
}