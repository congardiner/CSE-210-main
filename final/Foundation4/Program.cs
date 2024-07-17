using System;

class Program
{
    static void Main(string[] args)
    {


        // objects of instances that have been created //

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 17), 60, 2.7),
            new Cycling(new DateTime(2024, 7, 16), 30, 12),
            new Swimming(new DateTime(2024, 7, 15), 64, 6)

        };
        // will need to add my AddActivity for your methods. //


        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

        }
    }
}