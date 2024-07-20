using System;


public class Swimming : Activity
{
    private int _laps;
    


    // edit note: still need to add my constructor with the base method and the instances from the parent class //
    public Swimming(DateTime date, int durationMinutes, int laps) :base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance(bool inKm)
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return inKm ? distance : ConvertMiles(distance);
    }

    public override double GetSpeed(bool inKph)
    {
        double speed = GetDistance(true) / GetDurationMinutes() * 60;
        return inKph ? speed : ConvertMiles(speed);
    }

    public override double GetPace(bool inKm)
    {
        return GetDurationMinutes() / GetDistance(inKm);
    }
}