using System;


public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string Topic, string Title)  
    : base(studentName, Topic)
    {
        _title = Title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetName();
        
        return $"{_title} by {studentName}";
    }
}