using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentAcademy = new Dictionary<string, List<double>>();
            int numberOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentAcademy.ContainsKey(studentName))
                {
                    studentAcademy[studentName] = new List<double>();
                }

                studentAcademy[studentName].Add(studentGrade);
            }

            foreach (var kvp in studentAcademy)
            {
                if (kvp.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
                }
            }
        }
    }
}
