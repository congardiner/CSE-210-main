using System;
using System.Diagnostics;
using System.Dynamic;



class Fraction 
{
    private int _top;
    private int _bottom;


    // constructors that I made for the basics of this assignment. I'll need to revisit these later to get more practice. //

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int addvalue)
    {
        _top = addvalue;
        _bottom = 1;
    }
        
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}.";
        return fraction;
    }
    
    
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}
