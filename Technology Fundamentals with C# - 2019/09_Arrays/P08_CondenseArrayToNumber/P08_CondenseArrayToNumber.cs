using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                int[] condesed = new int[nums.Length - 1];

                for (int i = 0; i < condesed.Length; i++)
                {
                    condesed[i] = nums[i] + nums[i + 1];
                }

                nums = condesed;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
