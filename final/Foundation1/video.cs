using System;
using System.Collections.Generic;
using System.Reflection;


public class Video 
{
    static string _title;
    static string _author;
    static int _length;
    // measured in seconds, just a note to remind me later //

    // constructor for activating my variables and then displaying them with a get and set. //

    // method for GetVideoDescription()


    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _length = seconds;
    }

    public string GetVideoDescription()
    {
        return $"title: {_title} | author: {_author} | {_length}";
    }


}