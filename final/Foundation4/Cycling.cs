using System;


public class Cycling : Activity
{
    private double _speed;

    // edit note: will need to add my constructor to actuate my base parent derived polymorphized classes //
    

    public Cycling(DateTime date, int durationMinutes, double speed, bool kiloSpeed) :base(date, durationMinutes)
    {
        _speed = kiloSpeed ? speed : ConvertKilometers(speed);
    }
    public override double GetSpeed(bool inKph)
    {
        return inKph ? _speed : ConvertMiles(_speed);   
    }

    // edit note: method for calculating distance is now working with my double! //
    public override double GetDistance(bool inKm)
    {
        double distance = _speed * GetDurationMinutes() / 60;
        return inKm ? distance : ConvertMiles(distance);
    }

    public override double GetPace(bool inKm)
    {
        return 60 /GetSpeed(inKm);
    }


}