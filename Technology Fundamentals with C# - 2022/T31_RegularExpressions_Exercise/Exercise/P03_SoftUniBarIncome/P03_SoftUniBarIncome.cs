using System;
using System.Text.RegularExpressions;

namespace P03_SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<name>[A-z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$[^\|\$\%\.]*?$";
            Regex regex = new Regex(pattern);

            double totalIncome = 0;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}

