using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        Lecture harrypotterLecture = new Lecture(
            "Harry Potter: The Collective Heritage Event",
            "Lecture",
            "For all of your wizardry needs, we are here to satisfy them together, as in this special hosted event we will be broadcasting live with MrBeast the entirety of all our special heritage events for wizards of all ages. No special ticketry is required. Free Event for all ages!",
            new DateTime(2024, 8, 1, 12, 0, 0),
            "4 Privet Drive, Little Whinging, Surrey, England",
            "8/1/2024",
            "Daniel Ratcliffe & Friends",
            1000000
        );


        Reception weddingEvent = new Reception(
            "myweddingday.rsvp@hotmail.com",
            "JJ & CC Wedding Ceremony",
            "Reception",
            "Email now to reserve your special guest seat!:)",
            new DateTime(2024, 10, 7, 16, 30, 0),
            "77 Stanton Ave, Alegeus Point, Georgia, United States",
            "2024-10-07"
        );

        Outdoor bassproshopEvent = new Outdoor(
            "Tropical Rainstorm",
            "87 degrees F",
            "Slip & Slide",
            "Special Outdoor Gathering",
            "Event will feature special slip and slide and new waterpark installment complimentary of the new Bass Pro Shop!",
            new DateTime(2024, 8, 14, 5, 0, 0),
            "174 Concord Dr, Angelton, Texas, United States",
            "2024-08-14"
        );


        List<Event> events = new List<Event> { harrypotterLecture, weddingEvent, bassproshopEvent };

        foreach (var type in events)
        {
            Console.WriteLine($"Event: {type.GetType().Name}");

            Console.WriteLine("\nStandard Details of the Event:");
            Console.WriteLine(type.GetStandardDetails());

            Console.WriteLine("\nFull Details of the Event:");  
            Console.WriteLine(type.GetFullDetails());

            Console.WriteLine("\nShort Description of the Event:");
            Console.WriteLine(type.GetShortDescription());

            Console.WriteLine("Hope to see you then!");
            Console.WriteLine("\n~EventManagement Staffing INC");
        }

    }
}