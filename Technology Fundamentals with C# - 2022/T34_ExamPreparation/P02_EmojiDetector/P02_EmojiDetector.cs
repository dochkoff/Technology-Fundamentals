using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace P02_EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dic = new Dictionary<string, int>();

            BigInteger coolThreshold = 1;
            foreach (var ch in input)
            {
                int num = 0;
                if (int.TryParse(ch.ToString(), out num))
                {
                    coolThreshold *= num;
                }
            }

            string pattern = @"(::|\*\*)[A-Z][a-z]{2,}(\1)";
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            int validEmojis = matches.Count;

            foreach (Match match in matches)
            {
                string emoji = match.ToString();
                int coolness = 1;

                foreach (char ch in emoji)
                {
                    if (char.IsLetter(ch))
                    {
                        coolness += (char)ch;
                    }
                }

                if (coolness >= coolThreshold)
                {
                    dic[emoji] = coolness;
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{validEmojis} emojis found in the text. The cool ones are:");

            foreach (var kvp in dic)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}