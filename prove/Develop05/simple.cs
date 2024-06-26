using System;
using System.Diagnostics;


public class Simple : Goal
{

    public Simple(string goalName, int points, string goalType, string goalDesc) : base(goalName, points, goalType, goalDesc)
    {
    }
        
    // add the method for the simple goal to my class (note made here for this as I design my program) //

    public override string AddActivity()
    {
        Console.WriteLine("What would you like to call this Simple Goal?");
        _goalName = Console.ReadLine();

        Console.WriteLine("How would you describe this activity?");
        _goalDesc = Console.ReadLine();

        bool pointValidation = false;
        while (!pointValidation)
        {
            Console.WriteLine("How many points should this Simple Activity be worth?");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                _points = points;
                pointValidation = true;
            }
            else 
            {
                Console.WriteLine("Please enter an integer, as my program won't handle anything otherwise. An example of this could be 100 points.");
                // need to either rewrite this so that it iterates until an integer has been inputted. //
            }
        }

        return $"Added a Simple Goal to the list: {_goalName} that holds a point value of {_points}. Here is the included description that you wrote: {_goalDesc}";
        // need to add _activityName, and _points to be allocated per the activity, or could prompt the user for what the goal is, along with how many points they think it should be worth? //
    }

    public override string ShowScore()
    {
        return $"Simple Goal Points so far: {_points}";
    }

    public override string ShowList()
    {
        return $"Current goals: {_goalName}, Goal Type: {_goalType}, Goal Description: {_goalDesc}";
        // show the list of active goals that have been outputted. //

    }

    public override bool ShowComplete()
    {
        return _points > 0;
        // not sure yet how to show that the goal has been marked complete other than just putting an 'X' next to it. //
    }

    // everything in my simple activity will basically remain the same as what is in the base goal class. //
}