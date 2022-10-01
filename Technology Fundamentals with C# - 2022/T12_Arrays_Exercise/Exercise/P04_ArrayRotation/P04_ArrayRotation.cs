using System;
using System.Linq;

namespace P04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string tempInput = input[0];

                for (int x = 0; x < input.Length - 1; x++)
                {

                    input[0 + x] = input[1 + x];

                }
                input[input.Length - 1] = tempInput;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
