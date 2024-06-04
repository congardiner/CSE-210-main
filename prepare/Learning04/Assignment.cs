using System;
using System.Runtime.InteropServices;


public class Assignment 
{

    private string _studentName;
    private string _topic;
        
    // this is our constructor, follows the same rule as the class, doesn't even need to be called void. //    
    public Assignment(string studentName, string Topic)
    {
        _studentName = studentName;
        _topic = Topic;
    }

    // established my getters and setters since this is a private set of string(s) //

    public string GetName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + "  " + _topic;
    }

}