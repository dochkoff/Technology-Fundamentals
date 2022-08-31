using System;

namespace P05_DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            string decryptedMessage = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char encryoptedSymbol = char.Parse(Console.ReadLine());
                char decryptedSymbol = (char)(encryoptedSymbol + key);
                decryptedMessage += decryptedSymbol;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
