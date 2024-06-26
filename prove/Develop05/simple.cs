using System;
using System.Diagnostics;


public class Simple : Goal
{

    public Simple(string activityName, int points, string activityDesc) : base(activityName, points, activityDesc, "Simple Goal")
    {
    }
        
    // add the method for the simple goal to my class (note made here for this as I design my program) //

    public override string AddActivity()
    {
        Console.WriteLine("What would you like to call this Simple Goal?");
        _activityName = Console.ReadLine();

        Console.WriteLine("How would you describe this activity?");
        _activityName = Console.ReadLine();

        Console.WriteLine("How many points should this Simple Activity be worth?");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            _points = points;
        }
        else 
        {
            Console.WriteLine("Please enter an integer, as my program won't handle anything otherwise.");
            _points = false;
            // need to either rewrite this so that it iterates until an integer has been inputted. //
        }

        // need to add _activityName, and _points to be allocated per the activity, or could prompt the user for what the goal is, along with how many points they think it should be worth? //
    }

    public override string ShowScore()
    {
        // add a constructor to get base score, ++ score, and add other scores //


    }

    public override string ShowList()
    {
        // show the list of active goals that have been outputted. //

    }

    // everything in my simple activity will basically remain the same as what is in the base goal class. //





}