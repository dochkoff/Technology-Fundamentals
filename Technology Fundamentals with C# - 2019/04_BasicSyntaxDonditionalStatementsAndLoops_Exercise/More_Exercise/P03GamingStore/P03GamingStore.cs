using System;

namespace P03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string gameName = string.Empty;
            double gamePrice = 0;
            double totalAmount = 0;

            while (gameName != "Game Time")
            {
                gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "Game Time":
                        gamePrice = 0;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                totalAmount += gamePrice;

                if (balance - totalAmount >= 0 && gamePrice > 0)
                {
                    Console.WriteLine($"Bought {gameName}");
                }
                else if (balance - totalAmount < 0)
                {
                    Console.WriteLine("Too Expensive");
                    totalAmount -= gamePrice;
                }
                else if (balance - totalAmount == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                gamePrice = 0;
            }

            if (balance > totalAmount)
            {
                Console.WriteLine($"Total spent: ${totalAmount:F2}. Remaining: ${balance - totalAmount:F2}");
            }
        }
    }
}