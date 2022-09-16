using System;

namespace P07_VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double coin = 0.0;
            double coinsSum = 0.0;

            while (command != "Start")
            {
                coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    coinsSum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                command = Console.ReadLine();
            }

            while (command != "End")
            {
                command = Console.ReadLine();

                switch (command)
                {
                    case "Nuts":
                        if (coinsSum >= 2)
                        {
                            coinsSum -= 2;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coinsSum >= 0.7)
                        {
                            coinsSum -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coinsSum >= 1.5)
                        {
                            coinsSum -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coinsSum >= 0.8)
                        {
                            coinsSum -= 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coinsSum >= 1)
                        {
                            coinsSum -= 1;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "End":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            if (command == "End")
            {
                Console.WriteLine($"Change: {coinsSum:F2}");
            }
        }
    }
}