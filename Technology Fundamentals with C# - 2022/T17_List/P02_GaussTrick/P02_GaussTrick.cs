using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> gaussTrick = new List<int>();

            if (numbers.Count % 2 == 0)
            {
                GaussTrick(ref numbers, gaussTrick);
            }
            else
            {
                GaussTrick(ref numbers, gaussTrick);

                gaussTrick.Add(numbers[0]);
            }

            Console.WriteLine(string.Join(" ", gaussTrick));
        }

        private static List<int> GaussTrick(ref List<int> numbers, List<int> gaussTrick)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                gaussTrick.Add(numbers[i] + numbers[numbers.Count - 1]);
                numbers.Remove(numbers[i]);
                numbers.Remove(numbers[numbers.Count - 1]);
                i = -1;
            }

            return gaussTrick;
        }
    }
}
