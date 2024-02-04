using System;
using System.Collections.Generic;
using System.IO;

public class Journal {

    private List<Entry> entries = [];
    private PromptGen promptGen = new PromptGen();
    
    public void AddEntry()
    {
        Entry newEntry = new Entry();

        //random prompt from PromptGen
        newEntry.Prompt = promptGen.RandomDisplayPrompt();
        Console.WriteLine($"Prompt: {newEntry.Prompt}");

        Console.Write(">> ");
        newEntry.Reponse = Console.ReadLine();
        newEntry.Date = DateTime.Now;

        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
        
            entry.DisplayEntry();
            Console.WriteLine("");
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a file name to save entries: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date.ToString("MM/dd/yyyy hh:mm")} | Prompt: {entry.Prompt} | >> {entry.Reponse}");
                }
            }
            Console.WriteLine("Entry saved\n");
        }
        else
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date.ToString("MM/dd/yyyy hh:mm")} | Prompt: {entry.Prompt} | >> {entry.Reponse}");
                }
            }
            // Console.WriteLine($"No file found under {fileName}.");
        }
    }


    public void LoadFile()
    {
        Console.Write("Enter the file name to load entries: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] parts = line.Split(new string[] { "|" }, 3, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Entry loadedEntry = new Entry
                        {
                            Date = date,
                            Prompt = parts[1].Trim().Replace("Prompt: ", ""),
                            Reponse = parts[2].Trim().Replace(">> ", "")
                        };
                        entries.Add(loadedEntry);
                    }
                }
            }

            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. No entries loaded.");
        }
    }


}