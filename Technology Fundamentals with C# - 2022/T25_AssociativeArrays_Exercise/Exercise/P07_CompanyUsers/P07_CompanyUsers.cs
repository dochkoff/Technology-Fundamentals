using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] companyInfo = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = companyInfo[0];
                string employeeID = companyInfo[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}