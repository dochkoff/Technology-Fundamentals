using System;

namespace P03_RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());

            int n = 0;
            int n1 = 1;
            int n2 = 1;

            if (index == 1 || index == 2)
            {
                Console.WriteLine(n1);
            }

            for (int i = 2; i < index; i++)
            {
                n = n1 + n2;

                n1 = n2;
                n2 = n;
            }

            Console.WriteLine(n);
        }
    }
}

