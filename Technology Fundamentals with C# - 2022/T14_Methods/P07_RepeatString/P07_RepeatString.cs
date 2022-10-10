using System;

namespace P07_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            PrintConcatenatedText(text, repeat);
        }

        private static void PrintConcatenatedText(string text, int repeat)
        {
            string concatenatedText = null;

            for (int i = 1; i <= repeat; i++)
            {
                concatenatedText += text;
            }
            Console.WriteLine(concatenatedText);
        }
    }
}
