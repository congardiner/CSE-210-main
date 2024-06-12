using System;
using System.Collections;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing String Option.");
        // expired boolean for when the timer is done, that can be set by the user, can put it into program.cs
        // need to put an a countdown animation for the activities, could be different for each one, or the same regardless. 
        // while loop that acts as a mainMenu for the mindfulness class, with the added options for reflection, listing, and breathing //


        

        Mindfulness mindfulness = new Mindfulness(
        "Mindfulness Activity", 
        DateTime.Now.ToString(), 10, 
        "Welcome to the Mindfulness Application, this can become your all in one hub for taking care of yourself, in the simple ways that matter!",
        "Thank you for taking the time to take care of yourself! It will pay off!",
        "Incorporated here are several activities centered around your wellbeing, namely, breathing, reflection, and listing based activities to help your headspace. Start today to embrace a new change!");
        Console.WriteLine(mindfulness.GetActivityDescription());


        // instance for my reflection activity //

        Reflection reflection = new Reflection(
            "Reflection Activity",
            DateTime.Now.ToString(),
            30, // Total duration in seconds
            "Welcome to the reflection activity.",
            "Thank you for reflecting!",
            "This activity involves thinking about meaningful experiences."
        );

        reflection.StartActivity();


        // need to make a while loop to simulate the Main Menu with options for the various activities //


        Console.WriteLine("Please enter a specific duration that you would like the breathing exercise to last");
        string input = Console.ReadLine();

        Console.WriteLine("Breathe in...");
        Console.WriteLine("Breathe out...");


        // what did I call for my breathing exercise to do again? //
    
        // need to insert a random parameter set for my prompts and questions that relate holistically to them //


    }
}