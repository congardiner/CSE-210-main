using System;
using System.Collections.Generic;
using System.Reflection;
using System.Transactions;


public class Video 
{
    public string _title;
    public string _author;
    public int _length;

    private List<Comment> _comments = new List<Comment>();
    // measured in seconds, just a note to remind me later //

    // constructor for activating my variables and then displaying them with a get and set. //

    // method for GetVideoDescription()
    // method for AddComments
    // method for GetCommentCount
    // 

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDescription()
    {
         Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} in seconds");
         Console.WriteLine($"Numbers of Comments on the Video: {GetCommentCount}");
         Console.WriteLine("Comments: ");

         foreach (var comment in _comments)
         {
            comment.Display();
         }

         Console.WriteLine();

    }

}