using System;

namespace P01_GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine()); //kg
            decimal hay = decimal.Parse(Console.ReadLine()); //kg
            decimal cover = decimal.Parse(Console.ReadLine()); //kg
            decimal weight = decimal.Parse(Console.ReadLine()); //kg

            for (int day = 1; day <= 30; day++)
            {
                food -= 0.3m;

                if (day % 2 == 0)
                {
                    hay -= food * 0.05m;
                }

                if (day % 3 == 0)
                {
                    cover -= weight / 3.0m;
                }

                if (food <= 0
                    || hay <= 0
                    || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }

                if (day == 30)
                {
                    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
                }
            }
        }
    }
}
