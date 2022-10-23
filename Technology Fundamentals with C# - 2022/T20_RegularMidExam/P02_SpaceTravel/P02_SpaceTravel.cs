using System;

namespace P02_SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rout = Console.ReadLine().Split("||");
            int fuell = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < rout.Length; i++)
            {
                string[] command = rout[i].Split();

                if (command[0] == "Travel")
                {
                    int lightYears = int.Parse(command[1]);
                    fuell -= lightYears;

                    if (fuell >= 0)
                    {
                        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command[0] == "Enemy")
                {
                    int enemyArmourPoints = int.Parse(command[1]);

                    if (ammunition >= enemyArmourPoints)
                    {
                        ammunition -= enemyArmourPoints;
                        Console.WriteLine($"An enemy with {enemyArmourPoints} armour is defeated.");
                    }
                    else
                    {
                        if (fuell >= enemyArmourPoints * 2)
                        {
                            fuell -= enemyArmourPoints * 2;
                            Console.WriteLine($"An enemy with {enemyArmourPoints} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    fuell += int.Parse(command[1]);
                    ammunition += 2 * int.Parse(command[1]);

                    Console.WriteLine($"Ammunitions added: {2 * int.Parse(command[1])}.");
                    Console.WriteLine($"Fuel added: {int.Parse(command[1])}.");
                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }
            }
        }
    }
}
