using System;


public class Event
{
    protected string _eventTitle;
    protected string _eventType;
    protected string _eventDescription;
    protected TimeSpan _time;
    protected string _eventAddress;
    protected string _eventDate;


    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle} | {_eventDescription} | \n{_time} | Date: {_eventDate} | Address: {_eventAddress} |";

    }

    public string GetFullDetails()
    {
        return $"Title: {_eventTitle} | {_eventDescription} | \n{_time} | Date: {_eventDate} | Address: {_eventAddress} |";
    }

    public string GetShortDescription()
    {
        return $"Type of Event: {_eventType}\nTitle {_eventTitle} | {_eventDate}";
    }



}