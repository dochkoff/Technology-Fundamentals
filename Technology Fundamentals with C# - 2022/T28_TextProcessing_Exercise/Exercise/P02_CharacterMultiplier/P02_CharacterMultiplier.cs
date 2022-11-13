using System;

namespace P02_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            string str1 = input[0];
            string str2 = input[1];
            int shortestString = Math.Min(str1.Length, str2.Length);
            int result = 0;

            for (int i = 0; i < shortestString; i++)
            {
                result += str1[i] * str2[i];
            }


            string longestString = str1;
            if (longestString.Length < str2.Length)
            {
                longestString = str2;
            }

            for (int i = shortestString; i < longestString.Length; i++)
            {
                result += longestString[i];
            }

            Console.WriteLine(result);
        }
    }
}