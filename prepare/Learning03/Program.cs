using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction(1/1);
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        Fraction test2 = new Fraction(5);
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());

        Fraction test3 = new Fraction(3/4);
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        Fraction test4 = new Fraction(7);
        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());

        Fraction test5 = new Fraction(27);
        Console.WriteLine(test5.GetFractionString());
        Console.WriteLine(test5.GetDecimalValue());

        Fraction test6 = new Fraction(123, 7);
        Console.WriteLine(test6.GetFractionString());
        Console.WriteLine(test6.GetDecimalValue());

        Fraction test7 = new Fraction(778, 2);
        Console.WriteLine(test7.GetFractionString());
        Console.WriteLine(test7.GetDecimalValue());

        Fraction test8 = new Fraction(67, 2);
        Console.WriteLine(test8.GetFractionString());
        Console.WriteLine(test8.GetDecimalValue());
        
    }
}

