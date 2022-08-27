using System;

namespace P07_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int totalQuantity = 0;
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                
                if (totalQuantity+quantity>tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalQuantity += quantity;
                }
            }
            Console.WriteLine(totalQuantity);
        }
    }
}
