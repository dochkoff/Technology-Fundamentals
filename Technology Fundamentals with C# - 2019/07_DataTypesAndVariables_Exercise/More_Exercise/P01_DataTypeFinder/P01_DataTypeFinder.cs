using System;

namespace P01_DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int dataTypeInt;
            float dataTypeFloat;
            char dataTypeChar;

            while (input!="END")
            {
                if (int.TryParse(input, out dataTypeInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out dataTypeFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out dataTypeChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (input == "true" || input == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
