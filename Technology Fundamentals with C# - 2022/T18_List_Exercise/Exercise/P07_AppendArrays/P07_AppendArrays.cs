using System;
using System.Linq;
using System.Collections.Generic;

namespace P07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();
            string fromRightToLeft = string.Join(" ", input);
            List<int> appendList = fromRightToLeft
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", appendList));
        }
    }
}