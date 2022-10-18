using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> onlyPositiveNums = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 0)
                {
                    onlyPositiveNums.Add(input[i]);
                }
            }

            if (onlyPositiveNums.Count > 0)
            {
                onlyPositiveNums.Reverse();
                Console.WriteLine(string.Join(" ", onlyPositiveNums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
