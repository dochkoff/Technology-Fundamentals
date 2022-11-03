using System;
using System.Collections.Generic;

namespace P03_WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());

            var wordDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < repeats; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordDict.ContainsKey(word))
                {
                    wordDict.Add(word, new List<string>());
                }

                wordDict[word].Add(synonym);
            }

            foreach (var word in wordDict)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}