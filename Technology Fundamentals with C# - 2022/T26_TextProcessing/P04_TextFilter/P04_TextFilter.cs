using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var currBanWord in bannedWords)
            {
                text.Replace(currBanWord, new string('*', currBanWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
