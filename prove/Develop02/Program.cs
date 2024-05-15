using System;
using System.Runtime.CompilerServices;

// Some creative notes that I could include, is inserting a few parameters into the prompt generator, so that the prompts don't overlap or repeat until they've been experienced.
// I could also make sure that the user has the option to choose a different prompt if they want to. 
class mainMenu 
{
    static void Main(string[] args)
    {
        Display();
    }

    static void Display()
    {
        Console.WriteLine("The Ultimate Journaling System. Does it have a name? Well no, but you do and that's what matters. This is the all in one hub, documenting and storing your memories for the future!");
        Console.WriteLine("This is the Main Menu:");
        Console.WriteLine("Access File (type 1)");
        Console.WriteLine("New Prompt (type 2)");
        Console.WriteLine("Save File (type 3)");
        Console.WriteLine("Quit Program (type 4)");
    }
}

class journalEntry()
{
    public string userEntry()
    {
        string randomPrompt = journalPrompt.GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        Console.WriteLine($"Prompt: {randomPrompt} ");
        Console.WriteLine($"Entry: ");
        Console.WriteLine();

        // how will they knew they've correctly saved to the file.
    }
}

// need to make these behaviors, rather than just characters as strings!
// Might be best to include a Main, Journal Entry, Prompt //
class journalPrompt
{

    public List<string> prompts { get; private set; }
    static journalPrompt()
    {
         // need to implement the Random promptGenerator here.
        prompts = new List<string>()
        {
        
         "What is one of highlights from your day?",
         "Did you have a funny, weird, or abnormal experience?",
         "Write the first word that comes to mind, and write a short paragraph about what the means to you based off of your day?",
         "Outline three things that you are grateful for, and why:",
         "Write about your favorite vacation, and one place that you'd like to visit:",
         "What did you do to 'love yourself' today?",
         "What is something that you did today that pushed you outside of your comfort zone, if you can't think of something, what will you do tomorrow? Be specific.",
         "Who did you serve today?",
         "What are some goals that you accomplished, or are working on for this week?",
         "Did you overcome a specific challenge today, and if so, what was it and how did you make it happen?",
         "What will you do tomorrow to make today memorable, worthwhile, and relivable?",
        };

        public static string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts);

            return prompts[index];
        }
    }

    static 


}



    