﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombAndPower[0])
                {
                    for (int j = 1; j <= bombAndPower[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }

                    for (int j = 1; j <= bombAndPower[1]; j++)
                    {
                        if (i + j > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }

                    numbers[i] = 0;
                }

            }

            Console.WriteLine(numbers.Sum());

            //My variant (75/100 in Judge)
            //int bomb = bombAndPower[0];
            //int power = bombAndPower[1];
            //int detRangeIndx = 2 * power + 1;
            //int detStartIndx = 0;
            //int detEndIndx = 0;

            //for (int bombIndex = 0; bombIndex < numbers.Count; bombIndex++)
            //{
            //    if (numbers[bombIndex] == bomb)
            //    {
            //        detStartIndx = bombIndex - power;
            //        detEndIndx = bombIndex + power;

            //        //no numbers left
            //        if (detStartIndx < 0 && detEndIndx <= numbers.Count - 1)
            //        {
            //            numbers.RemoveRange(0, detEndIndx + 1);
            //        }
            //        //no numbers right
            //        else if (detEndIndx > numbers.Count - 1 && detStartIndx >= 0)
            //        {
            //            numbers.RemoveRange(detStartIndx, (power + 1) + (numbers.Count - 1) - bombIndex);
            //        }
            //        //no numbers left & right
            //        else if (detStartIndx < 0 && detEndIndx > numbers.Count - 1)
            //        {
            //            numbers.RemoveRange(0, numbers.Count);
            //        }
            //        //in range
            //        else
            //        {
            //            numbers.RemoveRange(detStartIndx, detRangeIndx);
            //        }
            //    }
            //}

            //Console.WriteLine(numbers.Sum());
        }
    }
}
