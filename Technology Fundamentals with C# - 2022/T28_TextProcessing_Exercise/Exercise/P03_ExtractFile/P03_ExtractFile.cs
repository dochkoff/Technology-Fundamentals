using System;

namespace P03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\");

            string[] nameAndExt = input[input.Length - 1]
                .Split(".");

            Console.WriteLine($"File name: {nameAndExt[0]}");
            Console.WriteLine($"File extension: {nameAndExt[1]}");
        }
    }
}