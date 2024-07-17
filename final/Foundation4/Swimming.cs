using System;


public class Swimming : Activity
{
    private int _laps;
    


    // edit note: still need to add my constructor with the base method and the instances from the parent class //
    public Swimming(DateTime date, int durationMinutes, int laps) :base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
}