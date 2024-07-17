using System;

public class Lecture : Event
{
    private string _eventSpeaker;
    private int _eventCapacity;

    // need to set a constructor, 

    // edit note: changed my constructor to private instead of public. 
    public Lecture(string eventTitle, string eventType, string eventDescription, DateTime time, string eventAddress, string eventDate, string eventSpeaker, int eventCapacity) : base(eventTitle, eventType, eventDescription, time, eventAddress, eventDate)
    {
        _eventSpeaker = eventSpeaker;
        _eventCapacity = eventCapacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"Speaker Name: {_eventSpeaker} | Event Capacity: {_eventCapacity}";
    }


}