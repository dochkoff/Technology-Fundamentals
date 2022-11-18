using System;
using System.Text;

namespace P05_MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            // create empty string builder which will
            // give us a methods that we can use to build our string
            var sb = new StringBuilder();
            //safeguard if user tures something funny or forbiden
            int reminder = 0;

            if (multiplier == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(input[i].ToString());
                int product = currDigit * multiplier + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}