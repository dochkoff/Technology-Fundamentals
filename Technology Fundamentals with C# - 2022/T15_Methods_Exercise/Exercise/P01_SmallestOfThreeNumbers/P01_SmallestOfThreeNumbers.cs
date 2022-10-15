using System;
using System.Linq;

namespace P01_SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(num1, num2, num3));
        }

        private static int SmallestNumber(int num1, int num2, int num3)
        {
            int numMin = int.MaxValue;

            if (num1 < numMin)
            {
                numMin = num1;
            }

            if (num2 < numMin)
            {
                numMin = num2;
            }

            if (num3 < numMin)
            {
                numMin = num3;
            }

            return numMin;
        }
    }
}
