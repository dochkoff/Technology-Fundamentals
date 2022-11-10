using System;
using System.Linq;
using System.Collections.Generic;

namespace P01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {


            string line;

            while ((line = Console.ReadLine()) != "end")
            {
                string reversedLine = "";

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversedLine += line[i];
                }

                Console.WriteLine($"{line} = {reversedLine}");
            }

        }
    }
}