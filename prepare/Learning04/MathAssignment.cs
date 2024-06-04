using System;


public class MathAssignment : Assignment
{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string Topic, string Textbook, string Problems)  
    : base(studentName, Topic)
    {
        _textbookSection = Textbook;
        _problems = Problems;
    }

    public string GetTextBook()
    {
        return _textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    // method called for program and with getters and setters set as such //
    public string GetHomeList()
    {
        return $"Textbook Section: {_textbookSection} Problems: {_problems}";
    }
}