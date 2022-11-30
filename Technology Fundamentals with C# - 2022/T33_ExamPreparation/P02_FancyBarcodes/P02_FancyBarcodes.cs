using System;
using System.Text.RegularExpressions;

namespace P02_FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            Regex regex = new Regex(pattern);

            int numberOfBarcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    Regex regexGroup = new Regex(@"\d+");
                    MatchCollection matchCollection = regexGroup.Matches(input);

                    if (matchCollection.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", matchCollection)}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}