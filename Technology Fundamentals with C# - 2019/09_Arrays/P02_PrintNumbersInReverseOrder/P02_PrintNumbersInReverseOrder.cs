using System;

namespace P02_PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] inputOrder = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                int input = int.Parse(Console.ReadLine());
                inputOrder[i] = input;
            }

            for (int i = numbers - 1; i >= 0; i--)
            {
                Console.Write(inputOrder[i] + " ");
            }
        }
    }
}
