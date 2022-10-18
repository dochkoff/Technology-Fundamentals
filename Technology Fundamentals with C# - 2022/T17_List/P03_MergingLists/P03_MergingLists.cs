using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstGroup = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secoundGroup = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstGroup.Count, secoundGroup.Count); i++)
            {
                result.Add(firstGroup[i]);
                result.Add(secoundGroup[i]);
            }

            if (firstGroup.Count != secoundGroup.Count)
            {
                for (int i = Math.Min(firstGroup.Count, secoundGroup.Count) + 1; i <= LongerListCount(firstGroup, secoundGroup); i++)
                {
                    result.Add(LongerList(firstGroup, secoundGroup)[i - 1]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static int LongerListCount(List<int> list1, List<int> list2)
        {
            if (list1.Count >= list2.Count)
            {
                return list1.Count;
            }
            else
            {
                return list2.Count;
            }
        }

        private static List<int> LongerList(List<int> list1, List<int> list2)
        {
            if (list1.Count >= list2.Count)
            {
                return list1;
            }
            else
            {
                return list2;
            }
        }
    }
}
