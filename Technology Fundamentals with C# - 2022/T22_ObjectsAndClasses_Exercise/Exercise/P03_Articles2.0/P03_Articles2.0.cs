using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace P03_Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfCommands = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] inputInfo = Console.ReadLine()
                .Split(", ");

                string title = inputInfo[0];
                string content = inputInfo[1];
                string author = inputInfo[2];

                Article article = new Article(title, content, author);
                articles.Add(article);

            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}