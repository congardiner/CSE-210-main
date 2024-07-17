using System;


public class Outdoor : Event
{
    private string _weatherForeCast;
    private string _weatherTemp;

    public Outdoor(string weatherForeCast, string weatherTemp, string eventTitle, string eventType, string eventDescription, string time, string eventAddress, string eventDate)
        {
        // edit note: need to actuate the rest of my constructors from the parent class, as this is where I left off //
        _eventTitle = eventTitle;
        _eventType = eventType;
        _eventDescription = eventDescription;
        // need to adjust the time constraints as builtin by .net //
        _time = DateTime;
        _eventAddress = eventAddress;
        _eventDate = eventDate;
        _weatherForeCast = weatherForeCast;
        _weatherTemp = weatherTemp;

    }

    // need to just attach one of my methods from the parent class, and then display it here in conjunction with my GetDetails Method. //

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"The weather forecast for the Event is {_weatherForeCast} & temperature being {_weatherTemp}";
    }


}