using System.Net;

class Comments
{
    private string _author;
    private string _text;
    public Comments(string author, string comment)
    {
        _author = author;
        _text = comment;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public string GetComment()
    {
        return _text;
    }

 
}
