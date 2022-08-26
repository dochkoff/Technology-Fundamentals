using System;

namespace P06_TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secoundChar = (char)('a' + j);
                        char tirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secoundChar}{tirdChar}");
                    }
                }
            }
        }
    }
}
