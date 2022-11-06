using System;
using System.Linq;
using System.Collections.Generic;

namespace P02_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var preciousMetals = new Dictionary<string, int>();

            string metal;
            while ((metal = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!preciousMetals.ContainsKey(metal))
                {
                    preciousMetals[metal] = 0;
                }
                preciousMetals[metal] += quantity;
            }

            foreach (var kvp in preciousMetals)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}