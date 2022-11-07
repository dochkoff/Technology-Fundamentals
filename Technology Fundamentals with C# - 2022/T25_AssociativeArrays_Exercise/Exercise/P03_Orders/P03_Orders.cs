using System;
using System.Linq;
using System.Collections.Generic;

namespace P03_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, List<double>>();

            string order;
            while ((order = Console.ReadLine()) != "buy")
            {
                string[] orderInfo = order.Split();

                string productName = orderInfo[0];
                double productPrice = double.Parse(orderInfo[1]);
                double productQuantity = double.Parse(orderInfo[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders[productName] = new List<double>();
                    orders[productName].Add(productPrice);
                    orders[productName].Add(productQuantity);
                }
                else
                {
                    if (productPrice != orders[productName][0])
                    {
                        orders[productName][0] = productPrice;
                    }
                    orders[productName][1] += productQuantity;
                }
            }

            foreach (var kvp in orders)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):F2}");
            }
        }
    }
}