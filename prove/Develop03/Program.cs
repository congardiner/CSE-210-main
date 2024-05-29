using System;


// Here are some of my references that I used to learn and further develop my skills to code //
// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split //


class Program
{
    static void Main(string[] args)
    {
        // learned on Youtube as I've been exploring C# //
        Console.Title = "Scripture Memorizer Generator Application";
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WindowHeight = 60;



        
        // masked words are not being hidden with whitespace?
        
        Scripture scripture = new Scripture();

        scripture.DisplayScripture();

        
    }
}