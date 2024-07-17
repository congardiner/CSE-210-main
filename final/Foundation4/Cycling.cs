using System;


public class Cycling : Activity
{
    private double _speed;

    // edit note: will need to add my constructor to actuate my base parent derived polymorphized classes //
    

    public Cycling(DateTime date, int durationMinutes, double speed, bool metricSystem) :base(date, durationMinutes, metricSystem)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetDistance()
    {
        double distance = (_speed * GetDurationMinutes()) / 60;
        return MetricSystem() ? distance : ConvertToMiles(distance);
   
    }



}