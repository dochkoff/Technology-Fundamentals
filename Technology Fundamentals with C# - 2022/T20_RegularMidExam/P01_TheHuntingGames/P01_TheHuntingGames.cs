using System;

namespace P01_TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            decimal groupEnergy = decimal.Parse(Console.ReadLine());
            decimal dayWaterOnePerson = decimal.Parse(Console.ReadLine());
            decimal dayFoodOnePerson = decimal.Parse(Console.ReadLine());

            decimal totalWater = days * players * dayWaterOnePerson;
            decimal totalFood = days * players * dayFoodOnePerson;


            for (int i = 1; i <= days; i++)

            {
                decimal energyLost = decimal.Parse(Console.ReadLine());
                groupEnergy -= energyLost;

                if (groupEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05m;
                    totalWater *= 0.7m;
                }

                if (i % 3 == 0)
                {
                    totalFood -= totalFood / players * 1.0m;
                    groupEnergy *= 1.1m;
                }
            }

            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
            }
        }
    }
}
