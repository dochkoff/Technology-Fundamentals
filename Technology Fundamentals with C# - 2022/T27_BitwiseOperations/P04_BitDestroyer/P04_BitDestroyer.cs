using System;

namespace P04_BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bitwise
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = ~(1 << position);//after shift left with position we have mask with 1 value at current position and another are 0, but with ~(not) we have mask with 0 value at current position and another are 1
            int result = (number & mask);// taken the whole number with set 0 only at current position and now we have another number
            Console.WriteLine(result);

            //No bitwise
            //int inputNumber = int.Parse(Console.ReadLine());
            //int bitPosion = int.Parse(Console.ReadLine());

            //double result = 0;
            //var inputNumberBinary = new int[12];

            //for (int i = 0; i < inputNumberBinary.Length; i++)
            //{
            //    inputNumberBinary[i] = inputNumber % 2;
            //    inputNumber /= 2;

            //    if (inputNumber <= 0)
            //    {
            //        break;
            //    }
            //}

            //inputNumberBinary[bitPosion] = 0;

            //for (int i = inputNumberBinary.Length - 1; i >= 0; i--)
            //{
            //    result += inputNumberBinary[i] * Math.Pow(2, i);
            //}

            //Console.WriteLine(result);
        }
    }
}