//Create a class Article with the following properties:
//    • Title – a string
//    • Content – a string
//    • Author – a string


using System.Reflection.Metadata.Ecma335;

string[] input = Console.ReadLine().Split(", ");
string title = input[0];
string content = input[1];
string author = input[2];

Article article = new Article(title, content, author);

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(": ");
    switch (command[0])
    {
        case "Edit":
            article.Edit(command[1]);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(command[1]);
            break;
        case "Rename":
            article.Rename(command[1]);
            break;
    }
}
Console.WriteLine(article);
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

    public void Edit(string content)
    {
        Content = content;
    }

    public void ChangeAuthor(string author)
    {
        Author = author;
    }

    public void Rename(string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}