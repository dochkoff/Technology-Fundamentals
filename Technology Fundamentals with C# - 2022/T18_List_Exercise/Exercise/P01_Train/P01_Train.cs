using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> command = input.Split().ToList();

                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else if (command.Count == 1)
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(command[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
