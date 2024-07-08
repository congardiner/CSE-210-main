using System;


public class Comment
{

    public string _personName;
    public string _personComment;

    // will need a method for creating a person, and storing comment with them //

    public void Display()
    {
        Console.WriteLine($"- {_personName}: {_personComment}");
    }
    
    public string CreatePerson()
    {
        return $"{_personName}";
    }

    public string CreateComment()
    {
        return $"{_personComment}";
    }

    // public CreatePerson()
    // public CreateComment(person)





}