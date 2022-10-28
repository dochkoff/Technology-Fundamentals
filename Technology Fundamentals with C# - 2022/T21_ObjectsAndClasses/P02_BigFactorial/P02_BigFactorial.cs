using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace P02_BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 2; i <= inputNumber; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}