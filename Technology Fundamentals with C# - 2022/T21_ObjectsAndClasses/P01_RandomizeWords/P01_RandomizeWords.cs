using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(0, input.Length);

                string currentWord = input[i];
                string randomWord = input[randomIndex];

                input[i] = randomWord;
                input[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
