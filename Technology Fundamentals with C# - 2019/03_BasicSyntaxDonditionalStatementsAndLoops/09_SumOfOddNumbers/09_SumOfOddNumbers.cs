using System;

namespace _09_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int oddNumber = 1;
            int sum = 0;

            while (counter <= n)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
                counter++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}