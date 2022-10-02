using System;
using System.Linq;

namespace P06_EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool isFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                if (input.Length > 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += input[j];
                    }
                }

                if (input.Length > 1)
                {
                    for (int x = input.Length - 1; x > i; x--)
                    {
                        rightSum += input[x];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
