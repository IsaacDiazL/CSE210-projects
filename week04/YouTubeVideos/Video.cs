using System.Net;
using System.Net.Http.Headers;
using System.Reflection;

class Video
{
    private string _author;
    private string _title;
    private string _length;
    private List<Comments> _comments;

    public Video(string author, string title, string length)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = new List<Comments>();
    }
    public void AddComments(Comments comments)
    {
        _comments.Add(comments);

    }
    public int CommentsLength()
    {
        int numberComments = _comments.Count;
        return numberComments;
    }
    public void ShowDisplay()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length);
        Console.WriteLine($"Number of comments: {CommentsLength()}");
        foreach (var line in _comments)
        {
            Console.WriteLine($"--- {line.GetAuthor()}: {line.GetComment()}");
        }
        Console.WriteLine();
    }
}