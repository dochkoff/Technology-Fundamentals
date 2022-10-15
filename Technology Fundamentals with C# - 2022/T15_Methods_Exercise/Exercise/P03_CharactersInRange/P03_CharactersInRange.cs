using System;
using System.Linq;

namespace P03_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            CharsInRange(char1, char2);
        }

        private static void CharsInRange(int char1, int char2)
        {
            for (int i = Math.Min(char1, char2) + 1; i < Math.Max(char1, char2); i++)
            {
                Console.Write((char)(i) + " ");
            }
        }
    }
}
