using System;
using System.Collections.Generic;
using System.Threading;

// threading enabled for the spinner that I found, integrated, and adapted for my program. //


public class Reflection : Mindfulness
{   
    // integrated prompts list and questions //
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection(string title, string time, int countdown, string startUpMsg, string endActivity, string activityDescription)
        : base(title, time, countdown, startUpMsg, endActivity, activityDescription)
    {

        _prompts = new List<string> 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you had to overcome something difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something that was exemplary",
            "Think of a time where you felt like you were in the clouds, with no worries",
            "Think of a time where you had to overcome a difficult obstacle",
            "Think of a time that you were able to overcome a difficult circumstance?"
        };

        _questions = new List<string>
        {
            "What made this experience meaningful to you?",
            "In what ways did this help you grow?",
            "How would you change the approach to this situation, and if so, what did you enjoy most about it?",
            "How can you apply what you've learned to the life that you are living today",
            "What is the greatest takeaway from this experience, and why is that the case?",
            "Are there things from this activity that literally changed you?"
        };

    }
        // display method for the prompts

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int promptList = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptList]);
    }

    // display method for the questions //

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionList = random.Next(_questions.Count);
        return _questions[questionList];
    }

    // here is a method that I found how to create online for a spinner //

    public void ShowSpinner(int duration)
    {
        int delay = 100;
        string[] spinner = { "/", "-", "//", "|"};

        for (int i = 0; i < duration * 1000 / delay; i++)
        {
            Console.WriteLine(spinner[i % spinner.Length]);
            Thread.Sleep(delay);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }


    // this is my method for starting the activity, this will be replicated amongst the child classes that have been inherited, so that in essense its essentially the same. //




        // 









}