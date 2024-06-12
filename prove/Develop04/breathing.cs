using System;
using System.Reflection;
using System.Reflection.Metadata;


public class Breathing : Mindfulness
{
    private string _breathing;

    Breathing(string breathing, string title, int time, int countdown, string endactivity, string activitydescription) : base(title, time, countdown, endactivity, activitydescription) 
    {
        _breathing = breathing;
    }


    Console.WriteLine("Welcome to the Breathing Activity, the whole purpose of this is to actively guide you through breathing so that you can recenter yourself and live your life with greater peace of self.");

    public string GetBreathing()
    {
        string 

        return $"{_breathing} {}"
    }
    // need to have description of the activity //

    
    
    // ask the user for period of seconds in duration of breathing, the program itself will last 30 seconds at the max, but the duration can be anything between that amount of time //



    // add the breathe in and out messages, will need to have a timer associated with that here. //



    // need to add the getter and setters as well as the countdown, and parameters with the strings for how things are supposed to behave together. //



}