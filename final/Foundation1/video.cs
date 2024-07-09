using System;
using System.Collections.Generic;



public class Video 
{
    public string _title;
    public string _author;
    public int _length;

    private List<Comment> _comments = new List<Comment>();
    // measured in seconds, just a note to remind me later //
    // method for GetVideoDescription()
    // method for AddComments
    // method for GetCommentCount
    // edit note: added my () to resolve error with the Count function displaying. //

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
        // edit note: forgot my () within my GetCommentCount that was making it so that it wasn't callable //
         Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} in seconds");
         Console.WriteLine($"Numbers of Comments on the Video: {GetCommentCount()}");
         Console.WriteLine("Comments: ");

         foreach (var comment in _comments)
         {
            comment.Display();
         }

         Console.WriteLine();

    }

}