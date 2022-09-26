using System;

namespace P04_SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int charCount = int.Parse(Console.ReadLine());
            int sum =0;

            for (int i = 0; i < charCount; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}