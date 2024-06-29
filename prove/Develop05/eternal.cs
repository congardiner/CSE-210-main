using System;

public class Eternal : Goal
{


    // also need to add a method with a loop that makes it infinite in scope, so that it never ends, rewarding behavior via points throughout. //

    // constructor added to enable my base for my inherited instances. //
    public Eternal(string goalName, int points, string goalType, string goalDesc) : base(goalName, points, goalType, goalDesc)
    {
    }

    // added a for loop that handles my condition for the eternal goal(s) loop that would handle my ongoing goals. //


    public override string AddActivity()
    {
        Console.WriteLine("What would you like to call this Eternal Goal? (\nRemember this is one that doesn't ever end, because its eternal!)");
        _goalName = Console.ReadLine();

        Console.WriteLine("How would you describe this eternal goal?");
        _goalDesc = Console.ReadLine();

        bool pointValidation = false;
        while (!pointValidation)
        {
            Console.WriteLine("How many points should each occurrence of this Eternal Activity be worth?");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                _points = points;
                pointValidation = true;
            }
            else 
            {
                Console.WriteLine("Please enter an integer value. Anything else, especially letters are no bueno here!");
            }
        }

        return $"Added Eternal Goal: {_goalName} with {_points} points per time it is reported. Description of the Eternal Goal: {_goalDesc}";
        
    }

    public override string ShowScore()
    {
        return $"Eternal Goal Points: {_points}";
    }

    public override string ShowList()
    {
        return $"{_goalName} Type of Goal: {_goalType} Description of the Goal: {_goalDesc}";
        // show the list of active goals that have been outputted. //
    }

    public override bool ShowComplete()
    {
        return false;
        // goal will never be complete, could also just create a variable for the eternal goals class, that always ++ itself so that it stays above 0, making it so that the goals never run out or show complete? //
    }

    









}