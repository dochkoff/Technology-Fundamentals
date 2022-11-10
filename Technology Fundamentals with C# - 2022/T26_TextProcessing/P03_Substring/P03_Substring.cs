using System;

namespace P03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string occurrencess = Console.ReadLine();

            while (occurrencess.Contains(word))
            {
                int index = occurrencess.IndexOf(word);
                occurrencess = occurrencess.Remove(index, word.Length);
            }

            Console.WriteLine(occurrencess);
        }
    }
}