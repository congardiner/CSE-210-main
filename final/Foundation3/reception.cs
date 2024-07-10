using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string eventTitle, string eventType, string eventDescription, string time, string eventAddress, string eventDate) : base(eventTitle, eventDescription, time, eventAddress, eventDate)
    {
        _rsvpEmail = rsvpEmail;
    }

    
    public string GetDetails()
    {


    }


}