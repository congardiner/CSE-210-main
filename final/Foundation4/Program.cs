using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Performance Activity Tracker";
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;

        // objects of instances that have been created //

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 17), 60, 2.7, false),
            new Cycling(new DateTime(2024, 7, 16), 30, 12, true),
            new Swimming(new DateTime(2024, 7, 15), 64, 47)

        };


        foreach (var activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}