using System;
using System.Collections.Generic;
using System.IO;

public class Save 
{
    // will add previously used method of using a txt file that will be allocated to this program //


    private string _saveFile;

    public Save(string saveFile)
    {
        _saveFile = saveFile;
    }

    public void FileSaveMethod(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(_saveFile))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
    }

    public List<Goal> LoadFileMethod()
    {
        List<Goal> goals = new List<Goal>();

        if (File.Exists(_saveFile))
        {
            using (StreamReader readfile = new StreamReader(_saveFile))
            {
                string goaltext;
                // had to re-edit my instance variable, as I had mixed up my camelCase instance//
                while ((goaltext = readfile.ReadLine()) != null)
                {
                    Goal goal = Goal.FromString(goaltext);
                    goals.Add(goal);
                }
            }
        }

        else
        {
            Console.WriteLine("The file you are looking for doesn't yet exist. Try using the Save Method in the Main Menu first!");
        }

        return goals;
    }

}
    // need to load in the dependency libary for the StreamWriter //
    // added my previously made save method from my journal class //

