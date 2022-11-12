﻿using System;

namespace P03_PthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            //Bitwise
            int mask = 1 << position;//after shift left with position value we have 1 value in mask at current position but another are 0
            int result = (number & mask) >> position;//after shift right with position value we have 0 or 1 at last position but another are 0 using &
            Console.WriteLine(result);

            //No bitwise
            //for (int i = 0; i < position; i++)
            //{
            //    number /= 2;
            //}
            //Console.WriteLine(number % 2);
        }
    }
}