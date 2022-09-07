using System;
using System.Linq;

namespace P07_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sequenceNum = 0;
            int maxSequence = 0;
            int number = 0;
            int counter = 1;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Length > 1)
                {
                    if (input[i] == input[i + 1])
                    {
                        number = input[i];
                        counter++;


                    }
                    else
                    {
                        number = input[0];
                        counter = 1;
                    }

                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        sequenceNum = number;
                    }
                }
                else
                {
                    sequenceNum = input[i];
                    maxSequence = 1;
                }
            }

            while (maxSequence > 0)
            {
                Console.Write(sequenceNum + " ");
                maxSequence--;
            }
        }
    }
}
