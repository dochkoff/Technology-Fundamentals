using System;
using System.Linq;

namespace _01_EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int[] sumOfNames = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                char[] name = Console.ReadLine().ToCharArray();
                int sumOfChars = 0;

                for (int x = 0; x < name.Length; x++)
                {
                    if (name[x] == 'a' || name[x] == 'A'
                        || name[x] == 'e' || name[x] == 'E'
                        || name[x] == 'o' || name[x] == 'O'
                        || name[x] == 'i' || name[x] == 'I'
                        || name[x] == 'u' || name[x] == 'U'
                        || (name[x] == 'w' && x == 0))
                    {
                        sumOfChars += name[x] * name.Length;
                    }
                    else
                    {
                        sumOfChars += name[x] / name.Length;
                    }
                }

                sumOfNames[i] = sumOfChars;
                sumOfChars = 0;
            }

            Array.Sort(sumOfNames);

            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.WriteLine(sumOfNames[i]);
            }
        }
    }
}
