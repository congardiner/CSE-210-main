using System;

public class Eternal : Goal
{
    int eternal_goals;
    int _bonusPoints;

    // also need to add a method with a loop that makes it infinite in scope, so that it never ends, rewarding behavior via points throughout. //

    // constructor added to enable my base for my inherited instances. //
    public Eternal(string goalName, int points, string goalType, string goalDesc) : base(goalName, points, goalType, goalDesc)
    {
    }

    // added a for loop that handles my condition for the eternal goal(s) loop that would handle my ongoing goals. //


    public override string AddActivity()
    {
        
    }

    public override string ShowScore()
    {
        // add a constructor to get base score, ++ score, and add other scores //
    }

    public override string ShowList()
    {
        // show the list of active goals that have been outputted. //
    }






    
}