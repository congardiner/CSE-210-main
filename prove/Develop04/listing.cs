using System;
using System.Collections.Generic;

public class Listing : Mindfulness
{
    private List<string> _promptsList;
    private List<string> _userList;

    public Listing(string title, string time, int countdown, string startUpMsg, string endActivity, string activityDescription)
        : base(title, time, countdown, startUpMsg, endActivity, activityDescription)
    {
        _promptsList = new List<string>
        {
            "What are some your favorite memories from your childhood?",
            "Who are some superheroes in your life?",
            "What are the biggest advantages to being a college student?",
            "Why do you love your significant other?",
            "What is a key-defining moment for you in your life?",
            "What are some of the greatest ambitions that you have within your life?",
            "What are you going to do to accomplish your dreams?",
            "What life dreams scare you the most, in that they require an intense amount of effort to get there?",
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
        };

        _userList = new List<string>();
    }

    private string GetRandomPromptList()
    {
        Random random = new Random();
        int promptList = random.Next(_promptsList.Count);
        return _promptsList[promptList];
    }

    // Show spinner method
    public void ShowSpinner(int duration)
    {
        int delay = 100; // Duration of each spinner frame in milliseconds
        string[] spinner = { "/", "-", "\\", "|" };

        for (int i = 0; i < duration * 1000 / delay; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(delay);

            // Move the cursor back to overwrite the previous spinner character
            Console.Write("\b");
        }

        // Clear the last spinner character
        Console.Write(" ");
        Console.Write("\b");
    }

    public void StartupListing()
    {
        Console.WriteLine(_startUpMsg);

        // Prompt the user for the duration of time
        Console.Write("Please enter the desired duration in (seconds) for the Listing Activity: ");

        string input = Console.ReadLine();
        int duration;

        // Validator for the user input for the time duration
        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.Write("This is not a valid input type. Please enter a positive number for the duration in seconds: ");
            input = Console.ReadLine();
        }

        // Display a random prompt from the list
        string prompt = GetRandomPromptList();
        Console.WriteLine("\n" + prompt);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter your responses here: ");
            string response = Console.ReadLine();

            if (!string.IsNullOrEmpty(response))
            {
                _userList.Add(response);
            }
            else
            {
                Console.WriteLine("Please enter something to record your response. Try again!");
            }

            // Show spinner to simulate waiting time
            ShowSpinner(1); // You can adjust the spinner duration as needed
        }

        // Display the user's responses after the timer ends
        Console.WriteLine("\nThe timer has ended, congratulations for taking the time to take care of yourself!");
        Console.WriteLine("\nHere are your responses for this activity:");

        foreach (string response in _userList)
        {
            Console.WriteLine("- " + response);
        }

        // Display the standard finishing message
        Console.WriteLine(_endActivity);
    }
}

