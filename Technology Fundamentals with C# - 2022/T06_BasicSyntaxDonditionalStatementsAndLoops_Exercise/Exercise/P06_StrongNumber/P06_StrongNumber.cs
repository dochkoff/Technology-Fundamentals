using System;

namespace P06_StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numer = int.Parse(Console.ReadLine());

            int workNumber = numer;
            int divider = 10;
            int factorielDigit = 1;
            int totalSum = 0;

            for (int i = 0; i < numer.ToString().Length; i++)
            {
                workNumber %= 10;
                for (int x = 1; x <= workNumber; x++)
                {
                    factorielDigit *= x;
                }
                totalSum += factorielDigit;

                workNumber = numer / divider;
                divider *= 10;
                factorielDigit = 1;

            }

            if (totalSum == numer)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

