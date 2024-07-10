using System;

public class Lecture : Event
{
    private string _eventSpeaker;
    private string _eventCapacity;

    // need to set a constructor, 

    // edit note: changed my constructor to private instead of public. 
    private Lecture(string eventSpeaker, string eventCapacity, string eventTitle, string eventType, string eventDescription, string time, string eventAddress, string eventDate) : base(eventTitle, eventDescription, time, eventAddress, eventDate)
    {
        _eventSpeaker = eventSpeaker;
        _eventCapacity = eventCapacity;
    }

    private string GetFullDetails()
    {
        return $"Speaker Name: {_eventSpeaker} | Event Capacity: {_eventCapacity} |\n Event Title: {_eventTitle} | {_eventDescription} | {_eventDate} |\n {_time} | {_eventDate} | {_eventAddress}";
    }


}