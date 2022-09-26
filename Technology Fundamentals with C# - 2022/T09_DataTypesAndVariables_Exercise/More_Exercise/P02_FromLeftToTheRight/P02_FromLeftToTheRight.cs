using System;

namespace P02_FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesOfStrings; i++)
            {
                string input = Console.ReadLine();
                string leftInput = input.Split(' ')[0];
                string rightInput = input.Split(' ')[1];
                long leftPart = long.Parse(leftInput);
                long rightPart = long.Parse(rightInput);
                long sum = 0;

                if (leftPart >= rightPart)
                {
                    leftPart = Math.Abs(leftPart);
                    while (leftPart > 0)
                    {
                        sum += leftPart % 10;
                        leftPart /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    rightPart = Math.Abs(rightPart);
                    while (rightPart > 0)
                    {
                        sum += rightPart % 10;
                        rightPart /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}