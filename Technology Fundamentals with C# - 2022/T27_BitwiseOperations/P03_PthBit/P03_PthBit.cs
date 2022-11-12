using System;

namespace P03_PthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            for (int i = 0; i < position; i++)
            {
                number /= 2;
            }

            Console.WriteLine(number % 2);
        }
    }
}