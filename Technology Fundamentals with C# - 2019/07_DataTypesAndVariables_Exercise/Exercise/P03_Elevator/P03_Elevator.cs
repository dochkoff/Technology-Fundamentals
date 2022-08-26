using System;

namespace P03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling( people / capacity);

            Console.WriteLine(courses);
        }
    }
}
