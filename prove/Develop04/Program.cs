using System;
using System.Collections;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // expired boolean for when the timer is done, that can be set by the user, can put it into program.cs
        // need to put an a countdown animation for the activities, could be different for each one, or the same regardless. 
        // while loop that acts as a mainMenu for the mindfulness class, with the added options for reflection, listing, and breathing //

        /*
        Mindfulness mindfulness = new Mindfulness(
        "Mindfulness Activity", 
        DateTime.Now.ToString(), 10, 
        "Welcome to the Mindfulness Application, this can become your all in one hub for taking care of yourself, in the simple ways that matter!",
        "Thank you for taking the time to take care of yourself! It will pay off!",
        "Incorporated here are several activities centered around your wellbeing, namely, breathing, reflection, and listing based activities to help your headspace. Start today to embrace a new change!");
        */



        Breathing breathing = new Breathing(
            "Breathing Activty",
            DateTime.Now.ToString(), 10,
            "Welcome to the Breathing Activity",
            "Thank you for breathing, it literally will keep you going in life, keep it up!",
            "This Activity involves guided breathing exercises, that are designed to assist you in being able to regulate your stress through breathing. A simple exercise that takes 3-5 minutes that can save you mountain loads of stress in the longrun."            
        );

        // instance for my reflection activity //

        Reflection reflection = new Reflection(
            "Reflection Activity",
            DateTime.Now.ToString(),
            30, // Total duration in seconds
            "Welcome to the reflection activity!",
            "Thank you for reflecting!",
            "This activity involves thinking about meaningful experiences."
        );

        // objects created and called for my Listing Class //
        Listing listing = new Listing(
            "Listing Activity",
            DateTime.Now.ToString(),
            30, // default time I've set for all activities
            "Welcome to the Listing Activity!",
            "Thank you for taking the time to reflect!",
            "This Activity involves listing out specific things relating to a guided question, choose the time that you want it to last for and then enter whatever comes to mind until the timer ends! Try it out now!"
        );

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Main Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit Program");

            Console.WriteLine("Enter Your Choice");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.StartUpBreathing();
                    break;

                case "2":
                    reflection.GetStartActivity();
                    break;

                case "3":
                    listing.StartupListing();
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("This is not a valid response. Please enter either 1, 2, or 3 to use the application. Enter 4 to exit the program.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to enter the menu, or startup the program please!");
            }
        }


        // need to add a main menu option now //

        // need to make a while loop to simulate the Main Menu with options for the various activities //


        // this is where beathing will be handled //

        // what did I call for my breathing exercise to do again? //
    
        // need to insert a random parameter set for my prompts and questions that relate holistically to them //

        Console.WriteLine("Its been a pleasure to serve you today, enjoy peace of mind in the real-life now, come back soon!");

    }
}