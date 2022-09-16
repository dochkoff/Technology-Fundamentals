using System;

namespace P03_Vecation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekday = Console.ReadLine();

            double pricePerPerson = 0.0;
            int discountCode = 0;

            if (groupType == "Students")
            {
                switch (weekday)
                {
                    case "Friday":
                        pricePerPerson = 8.45;
                        break;
                    case "Saturday":
                        pricePerPerson = 9.8;
                        break;
                    case "Sunday":
                        pricePerPerson = 10.46;
                        break;
                }

                if (number >= 30)
                {
                    discountCode = 1;
                }
            }
            else if (groupType == "Business")
            {
                switch (weekday)
                {
                    case "Friday":
                        pricePerPerson = 10.9;
                        break;
                    case "Saturday":
                        pricePerPerson = 15.6;
                        break;
                    case "Sunday":
                        pricePerPerson = 16;
                        break;
                }

                if (number >= 100)
                {
                    discountCode = 2;
                }
            }
            else if (groupType == "Regular")
            {
                switch (weekday)
                {
                    case "Friday":
                        pricePerPerson = 15;
                        break;
                    case "Saturday":
                        pricePerPerson = 20;
                        break;
                    case "Sunday":
                        pricePerPerson = 22.5;
                        break;
                }

                if (number >= 10 && number <= 20)
                {
                    discountCode = 3;
                }
            }

            double totalSum = number * pricePerPerson;

            if (discountCode == 0)
            {
                Console.WriteLine($"Total price: {totalSum:F2}");
            }
            else if (discountCode == 1)
            {
                Console.WriteLine($"Total price: {totalSum * 0.85:F2}");
            }
            else if (discountCode == 2)
            {
                Console.WriteLine($"Total price: {(number - 10) * pricePerPerson:F2}");
            }
            else if (discountCode == 3)
            {
                Console.WriteLine($"Total price: {totalSum * 0.95:F2}");
            }
        }
    }
}

