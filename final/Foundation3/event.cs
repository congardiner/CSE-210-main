using System;


public class Event
{
    protected string _eventTitle;
    protected string _eventType;
    protected string _eventDescription;
    protected TimeSpan _time;
    protected string _eventAddress;
    protected string _eventDate;


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