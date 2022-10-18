﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < productsCount; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
