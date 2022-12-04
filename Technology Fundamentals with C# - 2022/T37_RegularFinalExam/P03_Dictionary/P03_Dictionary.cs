using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Linq;

namespace P03_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var allWorsAndDefs = Console.ReadLine();

            var dic = new Dictionary<string, List<string>>();

            string[] wordsWithDefs = allWorsAndDefs
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var wordWithDef in wordsWithDefs)
            {
                string[] wordWithDefArgs = wordWithDef
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string word = wordWithDefArgs[0];
                string def = wordWithDefArgs[1];

                if (!dic.ContainsKey(word))
                {
                    dic[word] = new List<string>();
                    dic[word].Add(def);
                }
                else
                {
                    dic[word].Add(def);
                }
            }

            string[] teacherTest = Console.ReadLine().Split(" | ");

            string command = Console.ReadLine();

            if (command == "Test")
            {
                foreach (var word in teacherTest)
                {
                    if (dic.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");

                        foreach (var definition in dic[word])
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                foreach (var word in dic)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}