using System;

namespace P05_PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputStart = int.Parse(Console.ReadLine());
            int inputEnd = int.Parse(Console.ReadLine());

            for (char i = (char)inputStart; i <= inputEnd; i++)
            {
                Console.Write(i+" ");
            }
        }
    }
}
