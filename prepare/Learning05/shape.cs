using System;


public abstract class Shape 
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }


    public void SetColor(string color)
    {
        _color = color;
    }

    // used from the project notes as reviewing the baseline requirements and learning how to use abstraction effectively //

    public abstract double GetArea();

}