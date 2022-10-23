using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> input = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "Done")
            {
                string command = input[0];

                if (command == "Add Book")
                {
                    string bookName = input[1];

                    if (!shelf.Contains(bookName))
                    {
                        shelf.Insert(0, bookName);
                    }
                }
                else if (command == "Take Book")
                {
                    string bookName = input[1];

                    if (shelf.Contains(bookName))
                    {
                        //removeAll
                        shelf.Remove(bookName);
                    }
                }
                else if (command == "Swap Books")
                {
                    string firstBook = input[1];
                    string secoundBook = input[2];

                    if (shelf.Contains(firstBook)
                        && shelf.Contains(secoundBook))
                    {
                        int firstBookIndex = shelf.IndexOf(firstBook);
                        int secoundBookIndex = shelf.IndexOf(secoundBook);

                        shelf.Remove(firstBook);
                        shelf.Remove(secoundBook);

                        shelf.Insert(firstBookIndex, secoundBook);
                        shelf.Insert(secoundBookIndex, firstBook);
                    }
                }
                else if (command == "Insert Book")
                {
                    string bookName = input[1];

                    if (!shelf.Contains(bookName))
                    {
                        shelf.Add(bookName);
                    }
                }
                else if (command == "Check Book")
                {
                    int bookIndex = int.Parse(input[1]);

                    if (bookIndex >= 0
                        && bookIndex < shelf.Count
                        && shelf.Count > 0)
                    {
                        Console.WriteLine(shelf[bookIndex]);
                    }
                }

                input = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine(string.Join(", ", shelf));
        }
    }
}
