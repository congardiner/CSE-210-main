using System;


public class Eternal : Goal
{
    int _bonusPoints;

    

    public override string AddActivity()
    {
        return base.AddActivity();
    }

    public override string ShowScore()
    {
        // add a constructor to get base score, ++ score, and add other scores //

    }

    public override string ShowList()
    {
        // show the list of active goals that have been outputted. //

    }

    public string AddBonusPoints(int _points) 
    {
        // will have a baseline int points = 0; and ++ for bonus points when the eternal goal has been self-reported //
        
        return int _points + _bonusPoints;
    }





    
}