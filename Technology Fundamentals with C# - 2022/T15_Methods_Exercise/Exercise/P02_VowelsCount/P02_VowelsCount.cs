using System;
using System.Linq;

namespace P02_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(VowelsConter(input));
        }

        private static int VowelsConter(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a'
                    || input[i] == 'e'
                    || input[i] == 'u'
                    || input[i] == 'i'
                    || input[i] == 'o')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
