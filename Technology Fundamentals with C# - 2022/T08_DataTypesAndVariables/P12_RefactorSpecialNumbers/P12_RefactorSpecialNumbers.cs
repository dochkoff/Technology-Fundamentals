using System;

namespace P12_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= counter; i++)
            {
                int sum = 0;
                int num = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                i = num;
                bool spacialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {spacialNum}");
            }
        }
    }
}
