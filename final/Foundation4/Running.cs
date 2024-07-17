using System;


public class Running : Activity
{
    private double _distance;

    // need to add my constructor(s) with my base method, that will be used to polymorphisize this class //

    public override double GetSpeed()
    {
        return base.GetSpeed();
    }

    public override double GetPace()
    {
        return base.GetPace();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }

}