using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);

                articles.Add(article);
            }

            //string line = Console.ReadLine();

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
