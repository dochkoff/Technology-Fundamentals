using System;
using System.Linq;

namespace P09_KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencesLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] bestSequence = new int[sequencesLenght];
            int bestSubSequence = 0;
            int bestSequenceSum = 0;
            int bestSequenceRow = 0;
            int bestSequenceIndex = 0;

            int rowCounter = 0;



            while (input != "Clone them!")
            {

                int[] sequence = input
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                int sequenceSum = sequence.Sum();
                rowCounter++;

                if (sequencesLenght == 1 && sequence[0] == 1)
                {
                    bestSequenceRow = 1;
                    bestSequenceSum = 1;
                    bestSequence = sequence;
                    break;
                }

                int subSequence = 0;
                int subSequenceMax = 0;
                int startingIndex = int.MaxValue;
                int lowerIndex = int.MaxValue;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        subSequence++;
                        startingIndex = i;

                    }
                    else
                    {
                        subSequence = 0;
                        startingIndex = int.MaxValue;
                    }

                    if (subSequence > subSequenceMax)
                    {
                        subSequenceMax = subSequence;
                    }
                    if (startingIndex < lowerIndex)
                    {
                        lowerIndex = startingIndex;
                    }
                }

                if (subSequenceMax > bestSubSequence)
                {
                    bestSequence = sequence;
                    bestSubSequence = subSequenceMax;
                    bestSequenceSum = sequenceSum;
                    bestSequenceIndex = lowerIndex;
                    bestSequenceRow = rowCounter;
                }
                else if (subSequenceMax == bestSubSequence && lowerIndex < bestSequenceIndex)
                {
                    bestSequence = sequence;
                    bestSequenceSum = sequenceSum;
                    bestSequenceIndex = lowerIndex;
                    bestSequenceRow = rowCounter;
                }
                else if (subSequenceMax == bestSubSequence && lowerIndex == bestSequenceIndex && sequenceSum > bestSequenceSum)
                {
                    bestSequence = sequence;
                    bestSequenceSum = sequenceSum;
                    bestSequenceRow = rowCounter;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceRow} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(" ", bestSequence));

        }
    }
}
