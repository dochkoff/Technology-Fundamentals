using System;
using System.Linq;

namespace P04_WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);

            //string[] input = Console.ReadLine().Split();

            //foreach (var word in input)
            //{
            //    if (word.Length%2==0)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
        }
    }
}