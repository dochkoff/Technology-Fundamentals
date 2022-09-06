using System;
using System.Linq;

namespace P05_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string topIntegers = string.Empty;


            for (int i = 0; i < input.Length; i++)
            {
                bool isBigger = true;
                for (int x = i + 1; x < input.Length; x++)
                {
                    if (input[i] <= input[x])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger == true)
                {
                    topIntegers += input[i] + " ";
                }
            }

            Console.WriteLine(topIntegers);
        }
    }
}
