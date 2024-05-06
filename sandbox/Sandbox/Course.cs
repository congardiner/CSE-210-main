using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Course
{
    public string _courseCode;

    public string _courseName;

    public int _creditHours;

    public string _color;
    // public refers to accessibility.
    
    public void Display() {
        Console.WriteLine("");
    }

}