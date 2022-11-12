using System;

namespace P04_BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int bitPosion = int.Parse(Console.ReadLine());

            double result = 0;
            var inputNumberBinary = new int[12];

            for (int i = 0; i < inputNumberBinary.Length; i++)
            {
                inputNumberBinary[i] = inputNumber % 2;
                inputNumber /= 2;

                if (inputNumber <= 0)
                {
                    break;
                }
            }

            inputNumberBinary[bitPosion] = 0;

            for (int i = inputNumberBinary.Length - 1; i >= 0; i--)
            {
                result += inputNumberBinary[i] * Math.Pow(2, i);
            }

            Console.WriteLine(result);
        }
    }
}