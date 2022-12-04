using System;
using System.Collections.Generic;

namespace P03_HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesInTheParty = int.Parse(Console.ReadLine());

            var heroesHP = new Dictionary<string, int>();
            var heroesMP = new Dictionary<string, int>();

            for (int i = 0; i < heroesInTheParty; i++)
            {
                string[] heroeArgs = Console.ReadLine().Split(" ");
                string heroName = heroeArgs[0];
                int hitPoints = int.Parse(heroeArgs[1]);
                int manaPoints = int.Parse(heroeArgs[2]);

                heroesHP[heroName] = hitPoints;
                heroesMP[heroName] = manaPoints;
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ");

                string cmdType = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (cmdType == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (heroesMP[heroName] >= mpNeeded)
                    {
                        heroesMP[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    heroesHP[heroName] -= damage;

                    if (heroesHP[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
                    }
                    else
                    {
                        heroesHP.Remove(heroName);
                        heroesMP.Remove(heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (cmdType == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    if (heroesMP[heroName] + amount > 200)
                    {
                        int recharge = 200 - heroesMP[heroName];
                        heroesMP[heroName] = 200;
                        Console.WriteLine($"{heroName} recharged for {recharge} MP!");
                    }
                    else
                    {
                        heroesMP[heroName] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    if (heroesHP[heroName] + amount > 100)
                    {
                        int heal = 100 - heroesHP[heroName];
                        heroesHP[heroName] = 100;
                        Console.WriteLine($"{heroName} healed for {heal} HP!");
                    }
                    else
                    {
                        heroesHP[heroName] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
            }

            foreach (var kvp in heroesMP)
            {
                string heroName = kvp.Key;
                int manaPoints = kvp.Value;
                int helthPoints = heroesHP[heroName];

                Console.WriteLine($"{heroName}");
                Console.WriteLine($"  HP: {helthPoints}");
                Console.WriteLine($"  MP: {manaPoints}");
            }
        }
    }
}

