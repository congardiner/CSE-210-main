using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class JournalEntry
{

    // get;, and set; (two sets of accessors that I can use to return and assign new values -- just including this as reference as I continue to learn new syntax within csharp!)
    public DateTime Date { get; }
    public string Entry { get; set; }
    private static List<string> prompts = new List<string>()
    {
        "What is one of the highlights from your day?",
        "Did you have a funny, weird, or abnormal experience?",
        "Write the first word that comes to mind, and write a short paragraph about what it means to you based on your day?",
        "Outline three things that you are grateful for, and why:",
        "Write about your favorite vacation, and one place that you'd like to visit:",
        "What did you do to 'love yourself' today?",
        "What is something that you did today that pushed you outside of your comfort zone, if you can't think of something, what will you do tomorrow? Be specific.",
        "Who did you serve today?",
        "What is your favorite new color, use the Adobe Color Wheel to get suggestions if you are lost!",
        "What are some goals that you accomplished, or are working on for this week?",
        "Did you overcome a specific challenge today, and if so, what was it and how did you make it happen?",
        "Who are you trying to become?",
        "What brings you joy? Truly, what is helping you through life right now?",
        "What will you do tomorrow to make today memorable, worthwhile, and relivable?",
    };
    
    public JournalEntry()
    {
        Date = DateTime.Now;
        Entry = GetUserEntry();
    }

    public JournalEntry(string entry)
    {
        Date = DateTime.Now;
        Entry = entry;
    }

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Count);
        return prompts[index];
    }

    private static string GetUserEntry()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        Console.WriteLine("Journal Entry: ");
        string journal = Console.ReadLine();
        Console.WriteLine();


        return journal;
    }

    public void Display()
    {
        Console.WriteLine($"Current Date/Time: {Date}");
        Console.WriteLine($"Journal Entry: {Entry}");
    }

    // this section will now enable me to have my datetime and my userentry fixated together, or concat.
    // ToShortDateString is excellent because it assigns the an ovveride to a previous method within a class to 'override' literally its previous behavior.
    public override string ToString()
    {
        return $"{Date.ToShortDateString()}: {Entry}";
    }

}