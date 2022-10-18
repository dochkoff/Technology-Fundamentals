using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> commands = input.Split().ToList();

                switch (commands[0])
                {
                    case "Delete":
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            if (numberList[i] == int.Parse(commands[1]))
                            {
                                numberList.Remove(int.Parse(commands[1]));
                                i = -1;
                            }
                        }
                        break;
                    case "Insert":
                        numberList.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
