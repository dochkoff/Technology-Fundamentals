using System;

namespace P11_MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int multipl = int.Parse(Console.ReadLine());

            for (int i = multipl; i <= 10; i++)
            {
                Console.WriteLine($"{integer} X {i} = {integer * i}");
            }

            if (multipl > 10)
            {
                Console.WriteLine($"{integer} X {multipl} = {integer * multipl}");
            }
        }
    }
}