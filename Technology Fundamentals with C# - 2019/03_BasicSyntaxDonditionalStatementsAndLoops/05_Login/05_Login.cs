using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string usernameReversed = string.Empty;

            int counter = 0;
            int length = username.Length - 1;
            while (length >= 0)
            {
                usernameReversed = usernameReversed + username[length];
                length--;
            }

            for (int i = 0; i < 4; i++)
            {
                string password = Console.ReadLine();

                if (password != usernameReversed && i <= 2)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password != usernameReversed && i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
            }
        }
    }
}