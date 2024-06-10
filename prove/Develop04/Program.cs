using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing String Option.");
        // expired boolean for when the timer is done, that can be set by the user, can put it into program.cs
        // need to put an a countdown animation for the activities, could be different for each one, or the same regardless. 
        // for loop that acts as a mainMenu for the mindfulness class, with the added options for reflection, listing, and breathing //


        Mindfulness mindfulness = new Mindfulness("Tile Here");
        Console.ReadLine();


        // what did I call for my breathing exercise to do again? //
        Breathing breathing = new Breathing("");

    }
}