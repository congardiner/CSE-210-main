using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Some creative notes that I could include, is inserting a few parameters into the prompt generator, so that the prompts don't overlap or repeat until they've been experienced.
// I could also make sure that the user has the option to choose a different prompt if they want to. 
class Program
{

    private JournalEntry journal = new JournalEntry();

    public void RunProgram()
    {
        bool options = true;

        while (options)
        {
            DisplayMenu();
            options = UserInput();
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.RunProgram();
    }
        
    private void DisplayMenu()
    {
        Console.WriteLine("The Ultimate Journaling System. Does it have a name? Well no, but you do and that's what matters.");
        Console.WriteLine("This is the all in one hub, documenting and storing your memories for the future!");
        Console.WriteLine("This is the Main Menu:");
        Console.WriteLine("1. Access File (type 1)");
        Console.WriteLine("2. New Prompt (type 2)");
        Console.WriteLine("3. Save File (type 3)");
        Console.WriteLine("4. Quit Program (type 4)");
    }

    private bool UserInput()
    {
        string maininput = Console.ReadLine();

        switch(maininput)
        {
            case "1":
                StartJournal();
                break;

            case "2":
                JournalPrompt();
                break;

            case "3":
                SaveFile();
                break;

            case "4":
                Console.WriteLine("Thank you for using the headspace journal, see you next time!");
                return false;

            default:
                Console.WriteLine("That is not a valid option in this menu, please type a valid response (ie, 1, 2, 3, 4)");
                break;

        }

       return true;
    }

    private void StartJournal()
    {
        journal.Display();
    }

    private void JournalPrompt()
    {
        string prompt = JournalEntry.GetRandomPrompt();
        Console.WriteLine(prompt);
        journal.Entry = Console.ReadLine();
    }

    private void SaveFile()
    {
        string filePath = "journal_file.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(journal.ToString());
            Console.WriteLine("The Journal Entry entered has officially been saved. Lets go!");
        }
    }

}







    