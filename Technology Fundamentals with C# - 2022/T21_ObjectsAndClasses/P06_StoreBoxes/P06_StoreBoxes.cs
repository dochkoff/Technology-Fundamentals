using System;
using System.Linq;
using System.Collections.Generic;

namespace P06_StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] boxInfo = input.Split();

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);
                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemsQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }

    class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemsQuantity = quantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemsQuantity { get; set; }
        public decimal BoxPrice
        {
            get
            {
                return ItemsQuantity * Item.Price;
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}