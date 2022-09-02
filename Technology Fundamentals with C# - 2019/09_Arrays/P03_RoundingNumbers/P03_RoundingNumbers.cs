using System;
using System.Linq;

namespace P03_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //version 1
            //string input = Console.ReadLine();
            //string[] splitInput = input.Split();

            //double[] inputNumbers = new double[splitInput.Length];
            //int[] intNums = new int[splitInput.Length];

            //for (int i = 0; i < splitInput.Length; i++)
            //{
            //    inputNumbers[i] = double.Parse(splitInput[i]);
            //    Console.WriteLine($"{inputNumbers[i]} => {(int)Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero)}");
            //}

            //version 2

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //izpolzva se System.Linq, vsima string, splitva go na masiv,
            //izbira vsichki stoinosti i gi parsva na double, pravi go na masiv

            int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = (int)Math.Round(input[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]} => {nums[i]}");
            }
        }
    }
}
