using System;


public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;
    private bool _metricSystem;
    
    
    // edit note: made an abstract method of the classes //

    // need to add the math calculations and the properties for it so that it works //

    protected Activity(DateTime date, int durationMinutes, bool metricSystem)
    {
        _date = date;
        _durationMinutes = durationMinutes;
        _metricSystem = metricSystem;
    }

    public virtual double GetSpeed() => GetDistance() / _durationMinutes * 60;

    public abstract double GetDistance();

    public virtual double GetPace() => _durationMinutes / GetDistance();

    public virtual string GetSummary()
    {
        // need to add the units for the various units of measurement and a bool to determine which one to use? //
        
        
        
        return $"{_date} + ({_durationMinutes} min)" +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph," +
               $"Pace: {GetPace():F1} min per mile"; 
        // need to add my calculations for each of the activity types as provided within the notes //
    }

    protected double CalculateSpeed(double distance)
    {
        return (distance / _durationMinutes) * 60;
    }

    protected double CalculatePace(double distance)
    {
        return _durationMinutes / distance;

    }
    
}