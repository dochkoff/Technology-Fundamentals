using System;

namespace P06_BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string isBalanced = string.Empty;
            int counter = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                char bracket;

                if (char.TryParse(input, out bracket))
                {
                    if (bracket=='(')
                    {
                        counter++;
                    }
                    else if(bracket==')')
                    {
                        counter--;
                    }
                }

                if (counter < 0 || counter > 1)
                {
                    isBalanced = "UNBALANCED";
                    break;
                }
                else
                {
                    isBalanced = "BALANCED";
                }
            }

            Console.WriteLine(isBalanced);
        }
    }
}
