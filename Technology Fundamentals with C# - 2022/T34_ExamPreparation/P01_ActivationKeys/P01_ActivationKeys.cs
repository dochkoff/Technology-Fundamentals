using System;
using System.Text;

namespace P01_ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder rawKey = new StringBuilder(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] instructions = command
                    .Split(">>>");

                string operation = instructions[0];

                if (operation == "Contains")
                {
                    string substring = instructions[1];
                    if (rawKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (operation == "Flip")
                {
                    string flipCase = instructions[1];
                    int startInd = int.Parse(instructions[2]);
                    int endInd = int.Parse(instructions[3]);

                    string substring = rawKey.ToString().Substring(startInd, endInd - startInd);

                    if (flipCase == "Upper")
                    {
                        rawKey.Replace(substring, substring.ToUpper());
                        Console.WriteLine(rawKey);
                    }
                    else if (flipCase == "Lower")
                    {
                        rawKey.Replace(substring, substring.ToLower());
                        Console.WriteLine(rawKey);
                    }
                }
                else if (operation == "Slice")
                {
                    int startInd = int.Parse(instructions[1]);
                    int endInd = int.Parse(instructions[2]);

                    rawKey.Remove(startInd, endInd - startInd);

                    Console.WriteLine(rawKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}