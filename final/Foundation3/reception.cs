using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string eventTitle, string eventType, string eventDescription, DateTime time, string eventAddress, string eventDate) : base(eventTitle, eventType, eventDescription, time, eventAddress, eventDate)
    {
        _rsvpEmail = rsvpEmail;
    }


    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email:{_rsvpEmail}";
    }


}