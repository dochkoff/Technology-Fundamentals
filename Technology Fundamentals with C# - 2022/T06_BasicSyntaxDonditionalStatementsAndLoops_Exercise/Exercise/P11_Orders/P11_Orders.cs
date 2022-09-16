using System;

namespace P11_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());

            double totalOrdersPrice = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double coffeePrice = pricePerCapsule * capsulesCount * daysInMonth;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");

                totalOrdersPrice += coffeePrice;
            }

            Console.WriteLine($"Total: ${totalOrdersPrice:F2}");
        }
    }
}
