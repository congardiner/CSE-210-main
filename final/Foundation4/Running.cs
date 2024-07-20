using System;


public class Running : Activity
{
    private double _distance;

    // need to add my constructor(s) with my base method, that will be used to polymorphisize this class //
    public Running(DateTime date, int durationMinutes, double distance, bool checkKilometerDistance) : base(date, durationMinutes)
    {
        _distance = checkKilometerDistance ? distance : ConvertKilometers(distance);
    }


   public override double GetDistance(bool inKm)
   {
      return inKm ? _distance : ConvertMiles(_distance);
   }

    public override double GetSpeed(bool inKph)
    {
        double speed = _distance / GetDurationMinutes() * 60;
        return inKph ? speed : ConvertMiles(speed);
    }

    public override double GetPace(bool inKm)
    {
        return GetDurationMinutes() / (inKm ? _distance : ConvertMiles(_distance));
    }

}