using System;

namespace P03_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split();

            double[] inputNumbers = new double[splitInput.Length];
            int[] intNums = new int[splitInput.Length];

            for (int i = 0; i < splitInput.Length; i++)
            {
                inputNumbers[i] = double.Parse(splitInput[i]);
                Console.WriteLine($"{inputNumbers[i]} => {(int)Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
