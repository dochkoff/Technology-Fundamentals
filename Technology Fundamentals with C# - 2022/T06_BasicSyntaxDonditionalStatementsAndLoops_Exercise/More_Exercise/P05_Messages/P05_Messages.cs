using System;

namespace P05_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            string combo = string.Empty;
            string message = string.Empty;
            int letterIndex = 0;

            for (int i = 0; i < counter; i++)
            {
                combo = Console.ReadLine();
                int numberOfDigits = combo.Length;
                int mainDigit = int.Parse(combo) % 10;
                int offset = 0;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = (mainDigit - 2) * 3 + 1;
                }
                else
                {
                    offset = (mainDigit - 2) * 3;
                }

                letterIndex = offset + numberOfDigits - 1;

                if (mainDigit == 0)
                {
                    message += " ";
                }
                else
                {
                    message += (char)(letterIndex + 97);
                }
            }

            Console.WriteLine(message);
        }
    }
}