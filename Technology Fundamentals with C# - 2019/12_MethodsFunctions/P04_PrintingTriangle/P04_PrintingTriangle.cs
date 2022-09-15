using System;

namespace P04_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            PrintRectangle(inputNumber);
            PrintRectangleReverced(inputNumber - 1);
        }

        private static void PrintRectangle(int inputNumber)
        {
            for (int col = 1; col <= inputNumber; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(row + " ");
                }

                Console.WriteLine();
            }
        }

        private static void PrintRectangleReverced(int inputNumber)
        {
            for (int col = inputNumber; col >= 1; col--)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(row + " ");
                }

                Console.WriteLine();
            }
        }
    }
}