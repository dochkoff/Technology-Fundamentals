using System;

namespace P08_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                char fisrtLetter = item[0];
                char lastLetter = item[^1]; //same as item.Lenght-1

                string numAsAString = item[1..^1]; //this will return everything betwieen 0 and the last index;
                double numberFromString = double.Parse(numAsAString);

                if (char.IsUpper(fisrtLetter))
                {
                    int positonOfTheLetter = fisrtLetter - 64;
                    numberFromString /= positonOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = fisrtLetter - 96;
                    numberFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positonOfTheLetter = lastLetter - 64;
                    numberFromString -= positonOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numberFromString += positionOfTheLetter;
                }

                sum += numberFromString;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}