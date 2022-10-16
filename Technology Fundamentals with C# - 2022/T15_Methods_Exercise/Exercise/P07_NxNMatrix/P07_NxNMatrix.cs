using System;

namespace P07_NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NxN(num);
        }

        private static void NxN(int num)
        {
            for (int r = 0; r < num; r++)
            {
                for (int c = 0; c < num; c++)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }
    }
}