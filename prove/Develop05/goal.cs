using System;
using System.Diagnostics;
using System.Net;

public abstract class Goal
{
    protected string _activityName;
    protected int _points;
    // based off of this, I'd want to use a protected instance //
    protected string _activityType;
    // will describe the activity that the user wants to identify it with //
    protected string _activityDesc;
    protected bool _completed;

    // added my constuctor to initialize my base class instances //

    public Goal(string activityName, int points, string activityType, string activityDesc)
    {
        _activityName = activityName;
        _points = points;
        _activityType = activityType;
        _activityDesc = activityDesc;
        _completed = false;
    }


    // added all of my methods that will be used within my derived classes and adjusted to their needs. //
    public abstract string AddActivity();

    public virtual string ShowScore()
    {
        return $"Points: {_points}";
    }

    public virtual string ShowList()
    {

        return $"Active Goals: {_activityName}, Goal Type: {_activityType}";
        // show the list of active goals that have been outputted. //

    }

    public virtual bool ShowComplete()
    {
        _completed = true;
        return _completed;
        // create a when loop for _activityType being completed and showing crossed off. //

    }

    // use an abstract base class for the main goal class, and then use the methods from there. //

}