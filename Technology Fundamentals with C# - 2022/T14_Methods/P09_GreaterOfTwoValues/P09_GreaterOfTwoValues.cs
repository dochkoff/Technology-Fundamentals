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
                GetMax(number1, number2);
            }
            else if (type == "char")
            {
                char char1 = char.Parse(input1);
                char char2 = char.Parse(input2);
                GetMax(char1, char2);
            }
            else
            {
                char[] stringToCharArry1 = input1.ToCharArray();
                char[] stringToCharArry2 = input2.ToCharArray();
                int sumOfChars1 = 0;
                int sumOfChars2 = 0;

                for (int i = 0; i < stringToCharArry1.Length; i++)
                {
                    sumOfChars1 += stringToCharArry1[i];
                    sumOfChars2 += stringToCharArry2[i];
                }

                if (sumOfChars1 > sumOfChars2)
                {
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input2);
                }
            }
        }

        private static void GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }

        private static void GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                Console.WriteLine(char1);
            }
            else
            {
                Console.WriteLine(char2);
            }
        }
    }
}
