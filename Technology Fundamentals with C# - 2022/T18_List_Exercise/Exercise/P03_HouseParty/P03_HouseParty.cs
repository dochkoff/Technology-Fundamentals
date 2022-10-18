using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            int counter = 0;
            List<string> command = new List<string>();
            List<string> names = new List<string>();

            while (numberOfCommands >= counter)
            {
                command = Console.ReadLine().Split().ToList();

                if (command[2] == "going!")
                {
                    if (names.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(command[0]);
                    }
                }
                else if (command[2] == "not")
                {
                    if (names.Contains(command[0]))
                    {
                        names.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }

                counter++;
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

