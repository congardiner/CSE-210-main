using System;


public class Event
{
    protected string _eventTitle;
    protected string _eventType;
    protected string _eventDescription;
    protected DateTime _time;
    protected string _eventAddress;
    protected string _eventDate;

    public Event(string eventTitle, string eventType, string eventDescription, DateTime time, string eventAddress, string eventDate)
        {
        // edit note: need to actuate the rest of my constructors from the parent class, as this is where I left off //
        _eventTitle = eventTitle;
        _eventType = eventType;
        _eventDescription = eventDescription;
        // need to adjust the time constraints as builtin by .net and just use the DateTime func//
        _time = time;
        _eventAddress = eventAddress;
        _eventDate = eventDate;

    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_eventTitle} | {_eventDescription} | \n{_time} | Date: {_eventDate} | Address: {_eventAddress} |";

    }

    public virtual string GetFullDetails()
    {
        return $"Title: {_eventTitle} | {_eventDescription} | \n{_time} | Date: {_eventDate} | Address: {_eventAddress} |";
    }

    // can either set my methods as virtual or abstract, however, then the entire class becomes abstract as well. //
    public virtual string GetShortDescription()
    {
        return $"Type of Event: {_eventType}\nTitle {_eventTitle} | {_eventDate}";
    }



}