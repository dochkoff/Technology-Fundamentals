using System;

namespace P01_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {
                    bool charIsValid = true;

                    foreach (var ch in usernames[i])
                    {
                        if (!(char.IsLetterOrDigit(ch)
                            || ch == '-'
                            || ch == '_'))
                        {
                            charIsValid = false;
                            break;
                        }
                    }

                    if (charIsValid)
                    {
                        Console.WriteLine(usernames[i]);
                    }
                }
            }
        }
    }
}