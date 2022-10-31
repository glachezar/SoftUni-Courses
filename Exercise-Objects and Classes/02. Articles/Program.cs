using System;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(input[0], input[1], input[2]);

            int numberOfChanges = int.Parse(Console.ReadLine());

            //string title = input[0];
            //string content = input[1];
            //string author = input[2];

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ").ToArray();
                switch (tokens[0])
                {
                    case "Edit":
                        article.Content = article.Edit(tokens[1]);
                        break;
                    case "ChangeAuthor":
                        article.Author = article.ChangeAuthor(tokens[1]);
                        break;
                    case "Rename":
                        article.Title = article.Rename(tokens[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string name, string content, string author)
        {
            Title = name;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Rename(string newTitle)
        {
           return Title = newTitle;
        }

        public string Edit(string newContent)
        {
           return Content = newContent;
        }

        public string ChangeAuthor(string newAuthor)
        {
            return Author = newAuthor;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
