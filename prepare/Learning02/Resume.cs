using System;
using System.Configuration.Assemblies;


public class Resume
{

    public string _personName;


    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Full Name: {_personName}.");
        Console.WriteLine($"Jobs on File: ");
        Console.WriteLine("If you are looking for a new member to add to your team, now is the time!");    

        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

}