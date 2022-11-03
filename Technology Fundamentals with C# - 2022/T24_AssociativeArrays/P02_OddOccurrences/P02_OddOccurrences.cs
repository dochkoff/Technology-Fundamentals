using System;
using System.Collections.Generic;

namespace P02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            var wordsDict = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (wordsDict.ContainsKey(word))
                {
                    wordsDict[word]++;
                }
                else
                {
                    wordsDict.Add(word, 1);
                }
            }

            foreach (var word in wordsDict)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}