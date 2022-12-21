using System;
using System.Linq;

namespace P04_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = nums.Length / 4;

            //***
            int[] numsReverced = new int[nums.Length];

            for (int i = 0; i < k * 4; i++)
            {
                numsReverced[i] = nums[k * 4 - 1 - i];
            }

            int[] foldedNums = new int[k * 2];
            int[] middleNums = new int[k * 2];
            int[] result = new int[k * 2];

            int helpingIndex = 0;
            for (int i = k * 3; i < k * 4; i++)
            {
                foldedNums[helpingIndex] = numsReverced[i];
                helpingIndex++;
            }

            helpingIndex = k;
            for (int i = 0; i < k; i++)
            {
                foldedNums[helpingIndex] = numsReverced[i];
                helpingIndex++;
            }

            helpingIndex = 0;
            for (int i = k; i <= k * 3 - 1; i++)
            {
                middleNums[helpingIndex] = nums[i];
                helpingIndex++;
            }

            for (int i = 0; i < k * 2; i++)
            {
                result[i] = foldedNums[i] + middleNums[i];
            }

            Console.WriteLine(string.Join(' ', result));

            //***
            //int[] newArr = new int[2 * k];

            //for (int i = 0; i < k; i++)
            //{
            //    newArr[i] = inputArr[k - (i + 1)] + inputArr[k + i];
            //    newArr[newArr.Length - 1 - i] = inputArr[newArr.Length - 1 - i + k] + inputArr[(newArr.Length - 1 - i) + (k + 2 * i + 1)];
            //}
            //Console.WriteLine(string.Join(" ", newArr));
        }
    }
}

