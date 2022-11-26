using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            var furniture = new List<string>();

            double totalSpend = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(furnitureName);
                    totalSpend += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {totalSpend:F2}");
        }
    }
}