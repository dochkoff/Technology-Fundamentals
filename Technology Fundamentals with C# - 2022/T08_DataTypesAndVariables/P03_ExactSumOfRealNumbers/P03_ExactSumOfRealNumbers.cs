using System;
using System.ComponentModel;

namespace P03_ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            decimal sum=0M;
            for (int i = 0; i < counter; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
