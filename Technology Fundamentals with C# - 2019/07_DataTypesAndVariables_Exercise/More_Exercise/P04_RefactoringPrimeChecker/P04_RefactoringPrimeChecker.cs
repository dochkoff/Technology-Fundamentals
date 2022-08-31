using System;

namespace P04_RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= inputNumber; currentNumber++)
            {
                bool isPrime = true;

                for (int delitel = 2; delitel < currentNumber; delitel++)
                {
                    if (currentNumber % delitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime==true)
                {
                    Console.WriteLine($"{currentNumber} -> true");
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> false");
                }
            }

        }
    }
}
