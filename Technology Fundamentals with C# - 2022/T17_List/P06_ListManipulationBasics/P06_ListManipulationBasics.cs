using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            string[] commandSplit = command.Split().ToArray();


            while (command != "end")
            {
                commandSplit = command.Split().ToArray();

                switch (commandSplit[0])
                {
                    case "Add":
                        input.Add(int.Parse(commandSplit[1]));
                        break;
                    case "Remove":
                        input.Remove(int.Parse(commandSplit[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(commandSplit[1]));
                        break;
                    case "Insert":
                        input.Insert(int.Parse(commandSplit[2]), int.Parse(commandSplit[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
