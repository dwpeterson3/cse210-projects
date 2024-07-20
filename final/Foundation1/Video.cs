using System.Reflection;
using System.Collections.Generic;

public class Video{
    public string _title; 
    public string _author; 
    public int _videoLength; 
    public List<Comment> _comments; 

    public Video(string title, string author, int videoLength)
    {
        _title = title; 
        _author = author; 
        _videoLength = videoLength;
        _comments = new List<Comment>(); 
    }
    public void SaveComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public List<Comment> GetComments()
    {
        return _comments; 
    }
    public int NumberOfComments()
    {
        return _comments.Count; 
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of comments: {NumberOfComments()}");
        Console.WriteLine(); 
        foreach (Comment comment in GetComments())
        {
            Console.WriteLine($"Commenter: {comment._commenterName}, Comment: {comment._commentText}");
            Console.WriteLine(); 
        }

    }
}