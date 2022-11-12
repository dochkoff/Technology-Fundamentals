using System;

namespace P02_BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()) / 2 % 2;
            Console.WriteLine(number);
        }
    }
}