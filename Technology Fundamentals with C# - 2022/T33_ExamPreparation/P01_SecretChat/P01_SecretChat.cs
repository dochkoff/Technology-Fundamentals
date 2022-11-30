using System;
using System.Linq;

namespace P01_SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] steps = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                if (steps[0] == "InsertSpace")
                {
                    int index = int.Parse(steps[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (steps[0] == "Reverse")
                {
                    string substring = steps[1];

                    if (message.Contains(substring))
                    {
                        message = message.Remove(message.IndexOf(substring), substring.Length);
                        message += string.Join("", substring.Reverse());

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (steps[0] == "ChangeAll")
                {
                    string substring = steps[1];
                    string replacement = steps[2];

                    message = message.Replace(substring, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
