using System;

public class Comment
{
    public string _commenter;
    public string _text;

    public void DisplayComments()
    {
        Console.WriteLine($"Name: {_commenter}, Comment: {_text}");
    }
}