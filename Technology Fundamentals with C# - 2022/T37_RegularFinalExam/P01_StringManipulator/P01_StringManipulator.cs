using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Linq;

namespace P01_StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdName = cmdArgs[0];

                if (cmdName == "Translate")
                {
                    char ch = char.Parse(cmdArgs[1]);
                    char replacement = char.Parse(cmdArgs[2]);

                    while (input.Contains(ch))
                    {
                        input = input.Replace(ch, replacement);
                    }
                    Console.WriteLine(input);
                }
                else if (cmdName == "Includes")
                {
                    string substring = cmdArgs[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdName == "Start")
                {
                    string substring = cmdArgs[1];

                    if (input.StartsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdName == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (cmdName == "FindIndex")
                {
                    char ch = char.Parse(cmdArgs[1]);
                    Console.WriteLine(input.LastIndexOf(ch));
                }
                else if (cmdName == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
            }
        }
    }
}