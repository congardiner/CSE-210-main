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

        // maybe I could add a way to display the list of goals with a semicolon 
        // and add a checkmark to it when the goal has been marked as completed? //
    }

    public string AddChecklist()
    {
        // I would need to add a list that could store the checklist goals, along with my connected save class built into the other classes, so by default they can save within various parts of the program, rather than just at the menu. //


    }


}