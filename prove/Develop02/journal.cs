using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
class journalEntry()
{
    public string userEntry()
    {

        string randomPrompt = journalPrompt.GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        DateTime dateTime = DateTime.Now;
        string dateText = dateTime.ToShortDateString();

        Console.WriteLine($"Prompt: {randomPrompt} ");
        Console.WriteLine($"Entry: ");
        string response = Console.ReadLine();
        Console.WriteLine();

        
        public void Display()
        {
            WriteLine($"Date & Time: {_dateTime}");
            WriteLine($"User Response: {_journalEntry}");
        }

        public void FileSave(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Date & Time: {_dateTime}");
                writer.WriteLine($"Journal Entry: {_journalEntry}");
                writer.WriteLine();
            }
        }
        // how will they knew they've correctly saved to the file.
    }


}