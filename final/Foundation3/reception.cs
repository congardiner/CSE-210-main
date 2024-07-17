using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, string address, string rsvpEmail)
    {
        _eventTitle = title;
        _eventDescription = description;
        _time = DateTime.Time();
        // edit note: I had forgotten to add all of my variable instances. //
        _eventAddress = address;
        _rsvpEmail = rsvpEmail;
    }


    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"{_rsvpEmail}";
    }


}