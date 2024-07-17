using System;


public class Running : Activity
{
    private double _distance;

    // need to add my constructor(s) with my base method, that will be used to polymorphisize this class //
    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return IsMetric() ? _distance : ConvertToMiles(_distance);
    }

}