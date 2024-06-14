using System;
using System.Threading;


public class Breathing : Mindfulness
{
    private string _breathing;

    public Breathing(string title, string time, int countdown, string startUpMsg, string endactivity, string activitydescription) 
        : base(title, time, countdown, startUpMsg, endactivity, activitydescription) 
    {
    }
    


    // need to add my breathing in and out method and call it below in what will become my startup activity. //
    // created method for asking for the correct time in interval(s) and seconds for the breathing activity. 
    public void StartUpBreathing()
    {
        Console.WriteLine(_startUpMsg);

        Console.WriteLine("Please enter the an interval amount that you would like to do this in? (each interval is 5 seconds) ");
        string input = Console.ReadLine();
        int duration;

        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.WriteLine("Please enter a valid response, it has to be a positive integer, no negative or abstract numbers here. This is real life!");
            input = Console.ReadLine();
        }

        StartUpBreathingActivity(duration);
    }


    // starts up and simulates the breathing activity in full. //
        private void StartUpBreathingActivity(int duration)
    {
        int elapsedTime = 0;
        int breathingTime = 5;

        while (elapsedTime < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(breathingTime);

            Console.WriteLine("Breathe out...");
            ShowCountdown(breathingTime);

            elapsedTime += 2 * breathingTime;
        }

        Console.WriteLine(_endActivity);
    }



    // display method and timer that I used in the reflection activity to display progress being made. //
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - i.ToString().Length - 1, Console.CursorTop);
        }

        Console.WriteLine();
    }


}


    // need to have description of the activity //

    
    
    // ask the user for period of seconds in duration of breathing, the program itself will last 30 seconds at the max, but the duration can be anything between that amount of time //



    // add the breathe in and out messages, will need to have a timer associated with that here. //



    // need to add the getter and setters as well as the countdown, and parameters with the strings for how things are supposed to behave together. //


