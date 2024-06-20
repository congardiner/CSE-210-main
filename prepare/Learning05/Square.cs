using System;


public class Square : Shape
{
    private double _side;

    // make a constructor and then a getter //

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}