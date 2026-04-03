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

        Console.WriteLine($"Title: {_title}, Author: {_author}, Video Duration: {_length} seconds, Number of comments: {NumComments()} ");
        Console.WriteLine($"Comments: {_comments}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();
        }
    }
}