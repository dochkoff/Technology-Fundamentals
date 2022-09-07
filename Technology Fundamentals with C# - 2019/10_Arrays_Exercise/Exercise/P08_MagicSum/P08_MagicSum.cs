using System;
using System.Linq;

namespace P08_MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int k = i + 1; k < input.Length; k++)
                {
                    if (input[i] + input[k] == givenNumber)
                    {
                        Console.WriteLine(input[i] + " " + input[k]);
                    }
                }
            }
        }
    }
}
