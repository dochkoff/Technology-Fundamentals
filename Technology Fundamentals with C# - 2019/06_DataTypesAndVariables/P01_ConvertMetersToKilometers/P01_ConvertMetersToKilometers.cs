using System;

namespace P01_ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = Math.Round(meters / 1000,2);
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}