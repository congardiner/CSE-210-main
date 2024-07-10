using System;


public class Event
{
    private string _eventTitle;
    private string _eventType;
    private string _eventDescription;
    private TimeSpan _time;
    private string _eventAddress;
    private string _eventDate;


    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle} | {_eventDescription} | \n{_time} | Date: {_eventDate} | Address: {_eventAddress} |";

    }

    public string GetFullDetails()
    {
        
    }

    public string GetShortDescription()
    {
        return $"Type of Event: {_eventType}\nTitle {_eventTitle} | {_eventDate}";
    }



}