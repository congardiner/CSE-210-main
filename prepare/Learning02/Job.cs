using System;

public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public int _Salary;

    public void Display()
    {
        Console.WriteLine($"{_company} {_jobTitle} {_startYear} {_endYear}: person to be added shortly!");
    }

    public void DisplaySalary()
    {
        Console.WriteLine($"Here is the estimated salary for this position {_Salary}.");
    }

}

