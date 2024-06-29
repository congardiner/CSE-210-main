using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Checklist : Goal
{
    private int _checklistbonuspoints;
    // this will be rewarded once they get all of their checklist goals done //
    private int _currentCheck;
    private int _completeCheck;


    public Checklist(string goalName, int points, string goalType, string goalDesc, int checklistbonuspoints, int completeCheck) : base(goalName, points, goalType, goalDesc)
    {
        _checklistbonuspoints = checklistbonuspoints;
        _currentCheck = 0;
        _completeCheck = completeCheck;
    }

    public override string AddActivity()
    {
        Console.WriteLine("What would you like to call this Checklist Goal?");
        _goalName = Console.ReadLine();

        Console.WriteLine("How would you describe this Checklist Goal?");
        _goalDesc = Console.ReadLine();

        bool pointValidation = false;
        while (!pointValidation)
        {
            Console.WriteLine("How many points should this Checklist Goal actually be worth?");
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
        string xmark = _completed ? "[X]" : "[ ]";
        return $"Current goals: {_goalName}, Goal Type: {_goalType}, Goal Description: {_goalDesc} Progress Made: {_currentCheck}/{_completeCheck}";

    }

    public override bool ShowComplete()
    {
        return _currentCheck >= _completeCheck;
    }


}


    // Need to add my private variable also need my constructor and then a display method to showcase my points system and the list og goals /
        // need to add the points method 
        // add a constructor to get base score, ++ score, and add other scores //
        // show the list of active goals that have been outputted. //
        // maybe I could add a way to display the list of goals with a semicolon 
        // and add a checkmark to it when the goal has been marked as completed? //
   
        // I would need to add a list that could store the checklist goals, along with my connected save class built into the other classes, so by default they can save within various parts of the program, rather than just at the menu. //
