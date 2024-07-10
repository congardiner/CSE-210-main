using System;


public class Outdoor : Event
{
    private string _weatherForeCast;
    private string _weatherTemp;

    public Outdoor(string weatherForeCast, string weatherTemp, string eventTitle, string eventType, string eventDescription, string time, string eventAddress, string eventDate) : base (eventTitle, eventDescription, time, eventAddress, eventDate)
    {

    }



    public string GetDetails()
    {
        Console.WriteLine($"The weather forecast for the Event is {_weatherForeCast} & temperature being {_weatherTemp}");


    }



}