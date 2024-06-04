class SaveFile
{
    public void FileSave(string filePath, List<JournalEntry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (var entry in entries)
            {
                // changed the entries that are updated and saved with prior methods and attributes that have been called. //
                writer.WriteLine($"Date & Time: {entry.Date}");
                writer.WriteLine($"Journal Entry Title: {entry.Title}");
               /* writer.WriteLine($"Prompt: {entry.PromptUpdate}"); */
                writer.WriteLine($"Journal Entry: {entry.Words}");
                writer.WriteLine();
            }

        Console.WriteLine("This is a brief message just to ensure that your entry has been saved to the source file.");
        }
    }
}