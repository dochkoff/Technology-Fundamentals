using System;
using System.Linq;

namespace P02_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split().ToArray();
            string[] inputTwo = Console.ReadLine().Split().ToArray();

            string commonElements = string.Empty;

            for (int i = 0; i < inputTwo.Length; i++)
            {
                for (int x = 0; x < inputOne.Length; x++)
                {
                    if (inputTwo[i] == inputOne[x])
                    {
                        commonElements += inputTwo[i] + " ";
                    }
                }
            }

            Console.WriteLine(commonElements);
        }
    }
}
