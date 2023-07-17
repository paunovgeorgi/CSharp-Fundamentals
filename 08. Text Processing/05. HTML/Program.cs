using System.Text;

string title = Console.ReadLine();
string content = Console.ReadLine();
var comments = new List<string>();
string currentcomments;
while ((currentcomments = Console.ReadLine()) != "end of comments")
{
    comments.Add(currentcomments);
}

var sbTitle = new StringBuilder();
sbTitle.AppendLine("<h1>");
sbTitle.AppendLine("    " + title);
sbTitle.AppendLine("</h1>");

var sbContent = new StringBuilder();
sbContent.AppendLine("<article>");
sbContent.AppendLine("    " + content);
sbContent.AppendLine("</article>");

Console.Write(sbTitle);
Console.Write(sbContent);
foreach (var comment in comments)
{
    var sbComments = new StringBuilder();
    sbComments.AppendLine("<div>");
    sbComments.AppendLine("    " + comment);
    sbComments.AppendLine("</div>");
    Console.Write(sbComments);
}

