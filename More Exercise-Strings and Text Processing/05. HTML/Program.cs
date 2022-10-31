using System;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(<h1>Title</h1>)
            //article tag (<article></article>)
            //each comment should be in div tag (<div></div>)
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();

            Console.WriteLine($"<h1>\n{"    " + articleTitle}\n</h1>");
            Console.WriteLine($"<article>\n{"    " + articleContent}\n</article>");

            while (true)
            {
                string comments = Console.ReadLine();

                if (comments == "end of comments")
                {
                    break;
                }

                Console.WriteLine($"<div>\n{"    " + comments}\n</div>");
            }
        }
    }
}
