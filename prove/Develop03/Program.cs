using System;


// Here are some of my references that I used to learn and further develop my skills to code //
// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split //


class Program
{
    static void Main(string[] args)
    {
        // learned on Youtube as I've been exploring C# //

        Console.Title = "Scripture Memorizer Generator Application";
        Console.ForegroundColor = ConsoleColor.White;
        Console.WindowHeight = 10;

        // method for calling my scripture reference for the first verse.

        Reference singleVerseRef = new Reference("Alma 11", 12, 3);
        Console.WriteLine(singleVerseRef.GetScriptureReference());

        // method for calling my scripture reference for the second verse.

        Reference verseRange = new Reference("Alma", 37, 38, 39);
        Console.WriteLine(verseRange.GetScriptureReference());

        string textScriptures = "Sample Testing for my scriptures to see if this actually works!";
        Scripture scripture = new Scripture(textScriptures);

        Console.WriteLine("Original Scripture: " + scripture.GetScripture());

        scripture.HideWords(3);
        Console.WriteLine("3 words have been hidden: " + scripture.GetScripture());
        
        // masked words are not being hidden with whitespace?
        
        
        // Scripture scripture = new Scripture();
        // scripture.DisplayScripture();

        
    }
}