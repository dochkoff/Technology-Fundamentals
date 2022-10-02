using System;
using System.Linq;

namespace P03_Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsOfLines = int.Parse(Console.ReadLine());

            string evenRow = string.Empty;
            string oddRow = string.Empty;

            for (int i = 0; i < rowsOfLines; i++)
            {
                string[] inputRow = Console.ReadLine().Split().ToArray();

                if (i % 2 == 0)
                {
                    evenRow += inputRow[0] + " ";
                    oddRow += inputRow[1] + " ";
                }
                else
                {
                    evenRow += inputRow[1] + " ";
                    oddRow += inputRow[0] + " ";
                }
            }

            Console.WriteLine(evenRow);
            Console.WriteLine(oddRow);
        }
    }
}
