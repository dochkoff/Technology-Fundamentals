using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            var wordsDic = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (wordsDic.ContainsKey(word))
                {
                    wordsDic[word]++;
                }
                else
                {
                    wordsDic.Add(word, 1);
                }
            }

            foreach (var word in wordsDic)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
