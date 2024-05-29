using System;

class Program
{
    static void Main(string[] args)
    {
        // learned on Youtube as I've been exploring C# //
        Console.Title = "Scripture Generator";
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WindowHeight = 60;



        Words words = new Words();

        words.RevealRandom(true);
        
        // masked words are not being hidden with whitespace?
        Console.WriteLine("This is the beginning of the scripture generator");

        Scripture scripture = new scripture();

        scripture.DisplayScripture();

        
    }
}