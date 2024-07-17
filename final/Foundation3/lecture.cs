using System;

public class Lecture : Event
{
    private string _eventSpeaker;
    private int _eventCapacity;

    // need to set a constructor, 

    // edit note: changed my constructor to private instead of public. 
    public Lecture(string title, string description, DateTime dateTime, string address, string eventSpeaker, int eventCapacity)
    {
        _eventTitle = title;
        _eventType = "Lecture";
        _eventDescription = description;
        _time = DateTime.TimeOfDay;
        // not sure what to set the time to yet, as the system settings could mess up what the user sees if I use that library of DateTime.Now() or DateTime.TImeFromFile
        _eventDate = dateTime.ToShortDateString();
        _eventAddress = address;
        _eventSpeaker = eventSpeaker;
        _eventCapacity = eventCapacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker Name: {_eventSpeaker} | Event Capacity: {_eventCapacity}";
    }


}