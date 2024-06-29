using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _goalName;
    protected int _points;
    protected string _goalType;
    protected string _goalDesc;
    protected bool _completed;


    public string GoalName => _goalName;
    // added this instance that is handled to my method in program to extract the name of a created goal and mark it off accordingly //
    // need to add method for checking off my goals! 
    // thoughts for this: could be a simple if statement of select 1, 2, 3, or 4 if you completed a goal, which one would you like to mark off, and then close the program? //

    // added my constuctor to initialize my base class instances //

    public Goal(string goalName, int points, string goalType, string goalDesc)
    {
        _goalName = goalName;

        // edit note: created instance of being able to share this within the ShowComplete Method //


        _points = points;
        _goalType = goalType;
        _goalDesc = goalDesc;
        _completed = false;
    }

    // added all of my methods that will be used within my derived classes and adjusted to their needs. //
    public abstract string AddActivity();

    public abstract string ShowScore();
    public abstract string ShowList();
    // This created method should show the list of active goals that have been outputted. Testing in Progress! //
    public abstract bool ShowComplete();

    // added logic for creating a way to mark off completion of goals. //


    // added these testing methods to see how I can parse the goals, using serialization and deserialization as described in the documentation for using StreamReader and StreamWriter. //
    public override string ToString()
    {
        return $"{_goalType}|{_goalName}|{_points}|{_goalDesc}|{_completed}";
    }

    public static Goal FromString(string goaltext)
    {
        var parts = goaltext.Split('|');
        string goalType = parts[0];
        string goalName = parts[1];
        int points = int.Parse(parts[2]);
        string goalDesc = parts[3];
        bool completed = bool.Parse(parts[4]);

        if (goalType == "Simple")
        {
            var goal = new Simple(goalName, points, goalType, goalDesc);
            goal._completed = completed;
            return goal;
        }
        else if (goalType == "Eternal")
        {
            var goal = new Eternal(goalName, points, goalType, goalDesc);
            goal._completed = completed;
            return goal;
        }
        else if (goalType == "Checklist")
        {
            int checklistbonuspoints = int.Parse(parts[5]);
            int completeCheck = int.Parse(parts[6]);
            var goal = new Checklist(goalName, points, goalType, goalDesc,checklistbonuspoints, completeCheck);
            goal._completed = completed;
            return goal;
        }

        // documentation said to add a throw statement, not sure if this is how to do it though? //

        throw new InvalidOperationException("This is not a goal type that will work. You've gotta try again!");

    }



}