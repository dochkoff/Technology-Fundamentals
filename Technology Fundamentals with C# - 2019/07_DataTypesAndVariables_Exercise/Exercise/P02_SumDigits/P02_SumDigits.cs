using System;

namespace P02_SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = number;
            for (int i = 0; i < number.ToString().Length; i++)
            {   
                sum += digit%10;
                digit /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
