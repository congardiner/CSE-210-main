using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Assignment personDetails = new Assignment("Conner", "Math");
        Console.WriteLine(personDetails.GetSummary());

        MathAssignment math = new MathAssignment("Conner", "Math", "11.4", "1-4");
        Console.WriteLine(math.GetHomeList());

        WritingAssignment writing = new WritingAssignment("Conner", "English", "Where the Red Fern Grows");
        Console.WriteLine(writing.GetWritingInformation());
    }
}