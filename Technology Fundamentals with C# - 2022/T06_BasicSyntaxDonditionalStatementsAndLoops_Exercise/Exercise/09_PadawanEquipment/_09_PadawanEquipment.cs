using System;

namespace _09_PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsaberSum = Math.Ceiling(students * 1.1) * lightsaberPrice;
            double robeSum = students * robePrice;
            double beltSum = (students - Math.Floor(students / 6)) * beltPrice;

            double equipmentSum = lightsaberSum + robeSum + beltSum;

            if (budget >= equipmentSum)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {equipmentSum - budget:F2}lv more.");
            }
        }
    }
}