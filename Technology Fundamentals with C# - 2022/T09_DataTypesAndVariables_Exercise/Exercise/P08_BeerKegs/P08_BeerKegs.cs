using System;

namespace P08_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string kegModel = string.Empty;
            double radius = 0;
            int height = 0;
            double biggestKegVolume = double.MinValue;
            string biggestKegModel = string.Empty;

            for (int i = 0; i < n; i++)
            {
                kegModel = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * radius * radius * height;

                if (kegVolume>biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
