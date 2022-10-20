using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> target = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] command = input.Split().ToArray();

            int index = int.Parse(command[1]);
            int value = int.Parse(command[2]);

            if (command[0] == "Shoot")
            {
                if (index >= 0 && index < target.Count)
                {
                    target[index] -= value;

                    if (target[index] <= 0)
                    {
                        target.RemoveAt(index);
                    }
                }
            }
            else if (command[0] == "Add")
            {
                if (index >= 0 && index < target.Count)
                {
                    target.Insert(index, value);
                }
                else
                {
                    Console.WriteLine("Invalid placement!");
                }
            }
            else if (command[0] == "Strike")
            {
                if (index - value >= 0 && index + value < target.Count)
                {
                    target.RemoveRange(index - value, value * 2 + 1);
                }
                else
                {
                    Console.WriteLine("Strike missed!");
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join("|", target));
    }
}