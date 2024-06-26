using System;
using System.Collections.Generic;
/*
public class Checklist : Goal
{
    private int _checklist;

    public Checklist(string goalName, int points, string goalType, string goalDesc) : base(goalName, points, goalType, goalDesc)
    {
    }

    public override string AddActivity()
    {
        Console.WriteLine("What would you like to call this Checklist Goal?");
        _goalName = Console.ReadLine();

        Console.WriteLine("How would you describe this activity?");
        _goalDesc = Console.ReadLine();

        bool pointValidation = false;
        while (!pointValidation)
        {
            Console.WriteLine("How many points should this Checklist Activity be worth?");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                _points = points;
                pointValidation = true;
            }
            else 
            {
                Console.WriteLine("Please enter an integer, as my program won't handle anything otherwise. An example of this could be 100 points.");
            }
        }

        return $"Added a Checklist Goal to the list: {_goalName} that holds a point value of {_points}. Here is the included description that you wrote: {_goalDesc}";
    }

    public override string ShowScore()
    {
        return $"Checklist Goal Points so far: {_points}";
    }

    public override string ShowList()
    {
        return $"Current goals: {_goalName}, Goal Type: {_goalType}, Goal Description: {_goalDesc}";
    }

    public override bool ShowComplete()
    {
        return _points > 0;
    }
}

*/
    // Need to add my private instance, also need my constructor and then a display method to showcase my points system and the list og goals //
  




        // need to add the points method 
        // add a constructor to get base score, ++ score, and add other scores //


        // show the list of active goals that have been outputted. //

        // maybe I could add a way to display the list of goals with a semicolon 
        // and add a checkmark to it when the goal has been marked as completed? //
   
        // I would need to add a list that could store the checklist goals, along with my connected save class built into the other classes, so by default they can save within various parts of the program, rather than just at the menu. //
