using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace P02_Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticle = Console.ReadLine()
                .Split(", ");
            int numOfCommands = int.Parse(Console.ReadLine());

            string title = initialArticle[0];
            string content = initialArticle[1];
            string author = initialArticle[2];

            Article article = new Article(title, content, author);

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                string command = input[0];
                string change = input[1];

                if (command == "Edit")
                {
                    article.Edit(change);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(change);
                }
                else if (command == "Rename")
                {
                    article.Rename(change);
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string content)
        {
            return this.Content = content;
        }

        public string ChangeAuthor(string author)
        {
            return this.Author = author;
        }

        public string Rename(string title)
        {
            return this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}