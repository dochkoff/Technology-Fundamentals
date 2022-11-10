using System;
using System.Text;

namespace P02_RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            foreach (var word in input)
            {
                int count = word.Length;

                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}