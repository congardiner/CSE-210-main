using System;


public class Eternal : Goal
{
    int eternal_goals;
    int _bonusPoints;

    // also need to add a method with a loop that makes it infinite in scope, so that it never ends, rewarding behavior via points throughout. //

    // constructor added to enable my base for my inherited instances. //
    public Eternal (string _name, string _activityType, int _points, int _bonusPoints) : base ()
    {
        return _bonusPoints;
    }

    // added a for loop that handles my condition for the eternal goal(s) loop that would handle my ongoing goals. //
    while (true)
    {
        eternal_goals > 0 == ""
        
    }

    public override string AddActivity()
    {
        return base.AddActivity();
    }

    public override string ShowScore()
    {
        // add a constructor to get base score, ++ score, and add other scores //
        return base.ShowScore();

    }

    public override string ShowList()
    {
        // show the list of active goals that have been outputted. //
        return base.AddActivity();

    }


    public string AddBonusPoints() 
    {
        // will have a baseline int points = 0; and ++ for bonus points when the eternal goal has been self-reported //
        
        return _bonusPoints;
        // I can't access _points because it protected in the base class. //
    }





    
}