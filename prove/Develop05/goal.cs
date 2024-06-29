using System;
using System.Diagnostics;
using System.Net;

public abstract class Goal
{
    protected string _goalName;
    protected int _points;
    protected string _goalType;
    protected string _goalDesc;
    protected bool _completed;
    // need to add method for checking off my goals! 
    // thoughts for this: could be a simple if statement of select 1, 2, 3, or 4 if you completed a goal, which one would you like to mark off, and then close the program? //

    // added my constuctor to initialize my base class instances //

    public Goal(string goalName, int points, string goalType, string goalDesc)
    {
        _goalName = goalName;
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

}