using System;

namespace P05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Order(product, quantity);
        }

        private static void Order(string product, int quantity)
        {
            double productPrice = 0;

            switch (product)
            {
                case "coffee":
                    productPrice = 1.5;
                    break;
                case "water":
                    productPrice = 1;
                    break;
                case "coke":
                    productPrice = 1.4;
                    break;
                case "snacks":
                    productPrice = 2;
                    break;
                default:
                    Console.WriteLine("There is no such product.");
                    break;
            }

            double totalPrice = productPrice * quantity;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}