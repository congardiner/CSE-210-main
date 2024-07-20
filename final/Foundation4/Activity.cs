using System;


public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;
    
    
    // edit note: made an abstract method of the classes //

    // need to add the math calculations and the properties for it so that it works //

    protected Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public abstract double GetSpeed(bool inKph);

    public abstract double GetDistance(bool inKm);

    public abstract double GetPace(bool inKm);

    public virtual string GetSummary()
    {
        // edit note: need to add the units for the various units of measurement and a bool to determine which one to use? //
        // edit note: concat using ToString func for the date, and found the GetType() function for calling an attribute for the activity itself, or the object created as an instance of the activity class. //
        return $"\n{_date.ToString("MM-dd-yyyy")} {GetType().Name} & {_durationMinutes} minutes of exercise:" +
               $"\nDistance: {GetDistance(true):F2} kilometers per hour ({GetDistance(false):F2} miles per hour)" +
               $"\nSpeed: {GetSpeed(true):F2} kilometer per hour ({GetSpeed(false):F2} mph)," +
               $"\nPace: {GetPace(true):F2} min per kilometer ({GetPace(false):F2} min per mile)"; 
    }

    // conversions for miles to kilometers, using 0.621 //
    protected static double ConvertMiles(double kilometers) => kilometers * 0.621;
    protected static double ConvertKilometers(double miles) => miles / 0.621;
    protected int GetDurationMinutes() => _durationMinutes;
    
}