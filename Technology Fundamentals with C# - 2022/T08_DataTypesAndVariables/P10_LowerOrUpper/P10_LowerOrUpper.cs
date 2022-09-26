using System;

namespace P10_LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter>64 && letter<91)
            {
                Console.WriteLine("upper-case");
            }
            else if (letter > 96 && letter < 123)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}