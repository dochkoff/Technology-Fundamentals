using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangers = int.Parse(Console.ReadLine());
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < wagon.Count; i++)
            {
                while (wagon[i] < 4 && passangers > 0)
                {
                    wagon[i] += 1;
                    passangers--;
                }
            }

            if (passangers == 0 && wagon.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (passangers > 0 && wagon.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {passangers} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (passangers == 0 && wagon.All(x => x == 4))
            {
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}
