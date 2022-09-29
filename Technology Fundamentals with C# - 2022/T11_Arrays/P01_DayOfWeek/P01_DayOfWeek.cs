using System;

namespace _01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek =
             {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
             };

            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber>0 && inputNumber<8)
            {
                Console.WriteLine(dayOfWeek[inputNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
