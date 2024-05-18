using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Some creative notes that I could include, is inserting a few parameters into the prompt generator, so that the prompts don't overlap or repeat until they've been experienced.
// I could also make sure that the user has the option to choose a different prompt if they want to. 
class mainMenu 
{
    static void Main(string[] args)
    {
        Display();
    }

    static void Display()
    {
        Console.WriteLine("The Ultimate Journaling System. Does it have a name? Well no, but you do and that's what matters. This is the all in one hub, documenting and storing your memories for the future!");
        Console.WriteLine("This is the Main Menu:");
        Console.WriteLine("1. Access File (type 1)");
        Console.WriteLine("2. New Prompt (type 2)");
        Console.WriteLine("3. Save File (type 3)");
        Console.WriteLine("4. Quit Program (type 4)");
    }

}







    