using System;

class Program
{
    static void Main(string[] args)
    {

        Words words = new Words();

        words.RevealRandom(true);
        
        // masked words are not being hidden with whitespace?
        Console.WriteLine("This is the beginning of the scripture generator");

        Scripture scripture = new scripture();

        scripture.DisplayScripture();

        Words words = new Words("Testing Words Section:");

        
    }
}