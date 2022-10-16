using System;
using System.Linq;

namespace P05_AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = SubtractLastNumFromSum(num1, num2, num3);
            Console.WriteLine(result);
        }

        private static int SubtractLastNumFromSum(int num1, int num2, int num3)
        {
            int subtract = SumFirstTwoNums(num1, num2) - num3;
            return subtract;
        }

        private static int SumFirstTwoNums(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
