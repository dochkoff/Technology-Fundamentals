using System;
using System.Linq;

namespace P04_ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length/2; i++)
            {
                var oldInput = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = oldInput;
            }

            string output = string.Join(" ",input);
            Console.WriteLine(output);
        }
    }
}
