using System;
using System.Linq;

namespace P05_OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = result ^ numbers[i];
            }

            Console.WriteLine(result);

            //example with first input:
            //result=numbers[0]=1=001;
            //result=010^001=011;
            //result=011^011=000;
            //result=010^000=010;
            //result=011^010=001;
            //result=001^001=000;
            //result=011^000=011=3;
        }
    }
}

