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
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            var dic = new Dictionary<string, double>();

            foreach (var name in names)
            {
                if (!dic.ContainsKey(name))
                {
                    dic[name] = 0;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end of the race")
            {
                string name = @"[A-Za-z]";
                Regex regex = new Regex(name);
                MatchCollection match = Regex.Matches(command, name);

                string distance = @"[A-Za-z]";
                Regex regex = new Regex(distance);
                MatchCollection match = Regex.Matches(command, name);
            }
        }
    }
}