public class Video 
{
    string _title;
    string _author;
    double _lengthOfVideo;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double lengthOfVideo)
    {
        _title = title;
        _author = author;
        _lengthOfVideo = lengthOfVideo;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumComments()
    {
        return _comments.Count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Title: {_title}; Author: {_author}; Length: {_lengthOfVideo} seconds");
    }
    
    public void PrintComments()
    {
        for (int i = 0; i < _comments.Count; i++)
        {
            Console.WriteLine(_comments[i].PrintComment());
        }
    }
}