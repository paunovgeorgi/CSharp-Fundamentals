﻿namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < numOfArticles; i++)
            {
            string[] input = Console.ReadLine().Split(", ");
            string title = input[0];
            string content = input[1];
            string author = input[2];
                articles.Add(new Article(title, content, author));
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
        public class Article
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
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}