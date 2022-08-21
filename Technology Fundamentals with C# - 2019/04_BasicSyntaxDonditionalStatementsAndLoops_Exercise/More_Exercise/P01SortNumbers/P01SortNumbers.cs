using System;

namespace P01SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());

            if (x1 >= x2 && x2 >= x3)
            {
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                Console.WriteLine(x3);
            }
            else if (x1 <= x2 && x2 >= x3 && x1 >= x3)
            {
                Console.WriteLine(x2);
                Console.WriteLine(x1);
                Console.WriteLine(x3);
            }
            else if (x1 <= x2 && x2 >= x3 && x1 <= x3)
            {
                Console.WriteLine(x2);
                Console.WriteLine(x3);
                Console.WriteLine(x1);
            }
            else if (x1 <= x2 && x2 <= x3)
            {
                Console.WriteLine(x3);
                Console.WriteLine(x2);
                Console.WriteLine(x1);
            }
            else if (x1 >= x2 && x2 <= x3)
            {
                Console.WriteLine(x3);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
        }
    }
}