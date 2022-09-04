using System;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());

            int[] peopleInWagon = new int[wagonCount];
            int sum = 0;

            for (int i = 0; i < wagonCount; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagon[i];
            }

            string allPeopleInWagons = string.Join(" ", peopleInWagon);

            Console.WriteLine(allPeopleInWagons);
            Console.WriteLine(sum);
        }
    }
}
