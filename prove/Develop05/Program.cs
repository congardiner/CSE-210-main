using System;
using System.Collections.Generic;

public class ProgramClass
{
    static int goalCounter = 0;
    static int simpleCounter = 0;
    static int eternalCounter = 0;
    static int checklistCounter = 0;

    static int totalPoints = 0;
    static int currentLevel = 1;
    static int levelUpAmount = 500;

    // I didn't want to add another class, and have it encapsulated, so I just added a static method as the points methods were already routed here. //

    
    // will add all methods here for my various class method(s), especially those that have been polymorphized during this program, addactivity, showlist, showscore, etc //
    // all of my created objects stored here //


    static void Main(string[] args)
    {
        // list of resources used for my program --
        // https://stackoverflow.com/questions/7569904/easiest-way-to-read-from-and-write-to-files
        // Another option for the more credit is I could create a level system as suggested, using an if, else statement, with say incremental leveling up happening after every 1000 points. //
        // for the extra credit I could add a goal counter of those that have been counted vs those that haven't been counted //
        // color code the priorities of the goals you have, red mission critical, yellow is semi-critical, and green is all clear for now //

        // created instance for saving the file to this txt file // 
        string saveFile = "eternalquestgoals.txt";
        Save saved = new Save(saveFile);
    
        List<Goal> goals = new List<Goal>();

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
            Console.WriteLine("6. Record Progress");
            Console.WriteLine("7. Display the Total Score!");
            Console.WriteLine("8. Exit Program");

            Console.WriteLine("\nEnter Your Choice Here: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Simple newgoal = new Simple("", 0, "Simple", "");
                    Console.WriteLine(newgoal.AddActivity());
                    goals.Add(newgoal);
                    goalCounter++;
                    simpleCounter++;
                    break;

                case "2":
                    Eternal neweternal = new Eternal("", 0, "Eternal", "");
                    Console.WriteLine(neweternal.AddActivity());
                    goals.Add(neweternal);
                    goalCounter++;
                    eternalCounter++;
                    break;

                case "3":
                    Checklist newchecklist = new Checklist("", 0, "Checklist", "", 100, 5);
                    Console.WriteLine(newchecklist.AddActivity());
                    goals.Add(newchecklist);
                    goalCounter++;
                    checklistCounter++;
                    break;

                case "4":
                    saved.FileSaveMethod(goals);
                    Console.WriteLine("Goals you have written have been saved to the created file.");
                    // added my save Method //
                    break;
                
                case "5":
                    goals = saved.LoadFileMethod();
                    Console.WriteLine("Goals loaded straight from your file: ");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.ShowList());
                    }
                    // add load file of goals //
                    break;

                case "6":
                    Console.WriteLine("[X] will represent completed goals, whereas [ ] will represent goals that are still in progress.");
                    Console.WriteLine("\nReminder that Eternal Goals are always going to be in progress!");
                    MarkGoalAsComplete(goals);
                    break;

                case "7":
                    DisplayScores(goals);
                    break;

                case "8":
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

        Console.WriteLine("Amount of Recorded Entries for Goals---");
        Console.WriteLine($"Totals Accounted: {goalCounter}.");
        Console.WriteLine($"Simple: {simpleCounter} ");
        Console.WriteLine($"Eternal: {eternalCounter}");
        Console.WriteLine($"Checklist: {checklistCounter}");
            
        }
    }


    // added two static void methods that handle Displaying of total score points and as well as ensuring that the goals are actually marked complete. //
    static void DisplayScores(List<Goal> goals)
    {
        // here is where I'll add my leveling up system!
        Console.WriteLine($"Scores for all goals-- {totalPoints}");
        Console.WriteLine($"Current Active Level: {currentLevel}");

        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.ShowScore());
        }
    }

    static void LevelUpPoints(int points)
    {
        totalPoints += points;
        
        if (totalPoints >= currentLevel * levelUpAmount)
        {
            currentLevel++;
            Console.WriteLine($"Every 500 points you get to levelup! \nYou've now reached level {currentLevel}!\nLets go!");
        }
    }
    // tested my Mark Goal as complete method that is contained just within the program class, with the exception of calling _goalName, which is used within the goal class. //

    static void MarkGoalAsComplete(List<Goal> goals)
    {
        Console.WriteLine("Enter the name of the goal you want to mark as complete:");
        string goalName = Console.ReadLine();
        Goal goalToMark = goals.Find(g => g.GoalName == goalName);

        if (goalToMark != null)
        {
            goalToMark.ShowComplete();
            Console.WriteLine($"Goal '{goalName}' marked as complete.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

}