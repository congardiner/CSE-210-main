using System;

public class Checklist : Goal
{

    // Need to add my private instance, also need my constructor and then a display method to showcase my points system and the list og goals //
    private int _checklist;


    public override string AddActivity()
    {
        return base.AddActivity();
    }
    public override string ShowScore()
    {
        return base.ShowScore();
        // need to add the points method 
        // add a constructor to get base score, ++ score, and add other scores //

    }

    public override string ShowList()
    {
        return base.ShowList();
        // show the list of active goals that have been outputted. //
    }

    public string AddChecklistGoal()
    {
        


    }


}