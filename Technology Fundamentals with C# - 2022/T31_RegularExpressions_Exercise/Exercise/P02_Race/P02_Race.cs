using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var dic = new Dictionary<string, double>();

            foreach (var name in names)
            {
                if (!dic.ContainsKey(name))
                {
                    dic[name] = 0;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                Regex regexName = new Regex(@"[A-Za-z]");
                MatchCollection matchNames = regexName.Matches(command);
                string name = string.Empty;
                foreach (Match match in matchNames)
                {
                    name += match.Value;
                }

                Regex regexDistance = new Regex(@"[0-9]");
                MatchCollection matchDistances = regexDistance.Matches(command);
                double distance = 0;
                foreach (Match match in matchDistances)
                {
                    distance += double.Parse(match.Value);
                }

                if (dic.ContainsKey(name))
                {
                    dic[name] += distance;
                }
            }

            dic = dic.OrderByDescending(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine($"1st place: {dic.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {dic.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {dic.Keys.ElementAt(2)}");
        }
    }
}
