using System;
using System.Security.Cryptography.X509Certificates;
class journalEntry()
{
    public string userEntry()
    {
        
        string randomPrompt = journalPrompt.GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Prompt: {randomPrompt} ");
        Console.WriteLine($"Entry: ");
        string response = Console.ReadLine();
        Console.WriteLine();

        
        public void Display()
        {
            WriteLine($"Date & Time: {_DateTime}");
            WriteLine($"User Response: {_journalEntry}")
        }
        // how will they knew they've correctly saved to the file.
    }


}