using System;

// for my creative notes for this project, I've been doing some personal projects outside of this class to learn some more about c# so that when the group project comes around I am an asset to the team, with that being said, I learned how to edit, adjust, and use the terminal in C# this week. 
// Here are some of my references that I used to learn and further develop my skills to code //
// this channel has been immensely helpful to learning and combatting the fatigue of mastering some of the basic syntax of C#: Brackeys 
// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split //


class Program
{
    static void Main(string[] args)
    {
        // learned on Youtube as I've been exploring C# //

        Console.Title = "Scripture Memorizer Application";
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WindowHeight = 10;

        // method for calling my scripture reference for the first verse.

        Reference singleVerseRef = new Reference("Alma 11", 12, 3);
        Console.WriteLine(singleVerseRef.GetScriptureReference());

        // method for calling my scripture reference for the second verse. Still testing within my scripture class, not quite working just yet with the array I have setup. 
        /*
        Reference verseRange = new Reference("Alma", 37, 38, 39);
        Console.WriteLine(verseRange.GetScriptureReference());
        */

        // scripture class methods are all being called here with my word class too //
        string scriptureText = "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.";


        Scripture scripture = new Scripture(scriptureText);

        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetScripture());

        // while loop created to handle the input of the user, 'quit' to quit and 'enter' to enter. // 



        while (!scripture.ProgramComplete())
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }


            scripture.HideWords(3);
            Console.Clear();
            Console.WriteLine("Scripture with Hidden Words:");
            Console.WriteLine(scripture.GetScripture());
        }


        if (scripture.ProgramComplete())
        {
            Console.WriteLine("\nAll words are shown now, do you know what the scripture is? Now is the time to test it!");
            Console.WriteLine("\nTry the scripture generator again to see if you can perform this test from memory this time!");
        }


        else
        {
            Console.WriteLine("\nQuit was selected, you are exiting the program now. Happy Memorizing!");
        }
        
        // masked words are not being hidden with whitespace?


        
    }
}