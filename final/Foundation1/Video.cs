using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int NumComments()
    {
        return _comments.Count();
    }

    public void DisplayVideoInfo()
    {

        Console.WriteLine($"\n\nTitle: {_title}, \nAuthor: {_author}, \nVideo Duration: {_length} seconds, \nNumber of comments: {NumComments()} ");
        Console.WriteLine($"\nComments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();
        }
    }
}