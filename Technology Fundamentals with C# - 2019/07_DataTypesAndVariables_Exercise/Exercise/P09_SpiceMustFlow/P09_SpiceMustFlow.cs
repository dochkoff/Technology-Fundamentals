using System;

namespace P09_SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int extractedSpice = 0;
            int minedDays = 0;

            while (startingYield>=100)
            {
                extractedSpice += startingYield-26;
                startingYield -= 10;
                minedDays++;
            }

            if (extractedSpice >= 26)
            {
                extractedSpice -= 26;
            }

            Console.WriteLine(minedDays);
            Console.WriteLine(extractedSpice);
        }
    }
}