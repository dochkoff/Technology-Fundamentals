using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var charsCount = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!charsCount.ContainsKey(ch))
                    {
                        charsCount[ch] = 0;
                    }
                    charsCount[ch]++;
                }
            }

            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}