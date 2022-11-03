using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var sortedNums = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (sortedNums.ContainsKey(number))
                {
                    sortedNums[number]++;
                }
                else
                {
                    sortedNums.Add(number, 1);
                }
            }

            foreach (var number in sortedNums)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}