using System;
using System.Text.RegularExpressions;

namespace P01_MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matchColl = regex.Matches(input);

            foreach (Match item in matchColl)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}