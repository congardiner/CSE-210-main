using System;
using System.Collections.Generic;

public class ProgramClass
{
    static int goalCounter = 0;
    static int simpleCounter = 0;
    static int eternalCounter = 0;
    static int checklistCounter = 0;

    
    // will add all methods here for my various class method(s), especially those that have been polymorphized during this program, addactivity, showlist, showscore, etc //
    // all of my created objects stored here //


    static void Main(string[] args)
    {
        // list of resources used for my program --
        // https://stackoverflow.com/questions/7569904/easiest-way-to-read-from-and-write-to-files
        // Another option for the more credit is I could create a level system as suggested, using an if, else statement, with say incremental leveling up happening after every 1000 points. //
        // for the extra credit I could add a goal counter of those that have been counted vs those that haven't been counted //
        // color code the priorities of the goals you have, red mission critical, yellow is semi-critical, and green is all clear for now //
    
        List<Goal> goal = new List<Goal>();

        // can add the objects for my created goals here? //
        


        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Making Progress Starts Here!");
            Console.WriteLine("The Eternal Quest: Its Eternal");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Save Goal(s)");
            Console.WriteLine("5. Load Goal(s)");
            Console.WriteLine("6. Exit Program");

            Console.WriteLine("Enter Your Choice");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Simple newgoal = new Simple("", 0, "", "");
                    Console.WriteLine(newgoal.AddActivity());
                    goal.Add(newgoal);
                    goalCounter++;
                    simpleCounter++;
                    break;

                case "2":
                    Eternal neweternal = new Eternal("", 0, "", "");
                    Console.WriteLine(neweternal.AddActivity());
                    goal.Add(neweternal);
                    goalCounter++;
                    eternalCounter++;
                    break;

                case "3":
    
                    goalCounter++;
                    checklistCounter++;
                    break;
                case "4":
                    
                    // add save file method //
                    break;
                
                case "5":
                    // add load file of goals //
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("This is not a valid response. Please enter either 1, 2, 3, 4, 5, or 6 to use the application. Enter 6 to exit completely.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to enter the menu, or startup the program please!");
                Console.ReadKey();
            }
        
        // edit note: added my _goalCounter instance here to count how many goals have been worked on for the day //

        Console.WriteLine("Amount of Recorded Entries for Goals:");
        Console.WriteLine($"Totals Accounted: {goalCounter}.");
        Console.WriteLine($"Simple: {simpleCounter} ");
        Console.WriteLine($"Eternal: {eternalCounter}");
        Console.WriteLine($"Checklist: {checklistCounter}");
            
        }

    }
}