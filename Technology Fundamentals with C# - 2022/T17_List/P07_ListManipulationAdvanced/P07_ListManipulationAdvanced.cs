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
                    case "Contains":
                        if (input.Contains(int.Parse(commandSplit[1])))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No such number");
                        break;
                    case "PrintEven":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0)
                            {
                                Console.Write(input[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 != 0)
                            {
                                Console.Write(input[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(input.Sum());
                        break;
                    case "Filter":
                        switch (commandSplit[1])
                        {
                            case "<":
                                for (int i = 0; i < input.Count; i++)
                                {
                                    if (input[i] < int.Parse(commandSplit[2]))
                                    {
                                        Console.Write(input[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                for (int i = 0; i < input.Count; i++)
                                {
                                    if (input[i] > int.Parse(commandSplit[2]))
                                    {
                                        Console.Write(input[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                for (int i = 0; i < input.Count; i++)
                                {
                                    if (input[i] <= int.Parse(commandSplit[2]))
                                    {
                                        Console.Write(input[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                for (int i = 0; i < input.Count; i++)
                                {
                                    if (input[i] >= int.Parse(commandSplit[2]))
                                    {
                                        Console.Write(input[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }

                command = Console.ReadLine();

                if (command == "end"
                    && (commandSplit[0] == "Add"
                    || commandSplit[0] == "Remove"
                    || commandSplit[0] == "RemoveAt"
                    || commandSplit[0] == "Insert"))
                {
                    Console.WriteLine(string.Join(" ", input));
                }
            }
        }
    }
}
