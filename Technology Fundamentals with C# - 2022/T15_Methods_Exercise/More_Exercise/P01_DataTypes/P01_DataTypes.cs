using System;

namespace P01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string data = Console.ReadLine();

            if (dataType == "int")
            {
                int intNum = int.Parse(data);
                DataProcessing(intNum);
            }
            else if (dataType == "real")
            {
                double realNum = double.Parse(data);
                DataProcessing(realNum);
            }
            else
            {
                DataProcessing(data);
            }
        }

        static void DataProcessing(int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
        }

        static void DataProcessing(double number)
        {
            double result = number * 1.5;
            Console.WriteLine($"{result:F2}");
        }

        static void DataProcessing(string input)
        {
            Console.WriteLine("$" + input + "$");
        }
    }
}