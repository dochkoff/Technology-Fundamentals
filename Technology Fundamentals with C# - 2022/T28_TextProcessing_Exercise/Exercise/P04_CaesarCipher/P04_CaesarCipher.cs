using System;

namespace P04_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                char cipher = (char)(ch + 3);
                Console.Write(cipher);
            }
        }
    }
}

