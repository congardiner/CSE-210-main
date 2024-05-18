class SaveFile
{
    public void FileSave(string filePath, List<JournalEntry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date & Time: {entry._dateEntry}");
                writer.WriteLine($"Journal Entry: {entry._userEntry}");
                writer.WriteLine();
            }

        Console.WriteLine("This is a brief message just to ensure that your entry has been saved to the source file.");
        }
    }
}