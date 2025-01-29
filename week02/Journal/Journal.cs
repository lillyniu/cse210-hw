using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private string[] prompts = new string[]
    {
            "What are you the most grateful for today?",
            "What was a lesson that you learned from a struggle? ",
            "How did you grow from a trial you faced?",
            "How did you serve today?",
            "How will you improve tomorrow?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response is: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Date = DateTime.Now,
            Prompt = prompt,
            Response = response
        };

        entries.Add(entry);
        Console.WriteLine("Entry added! ");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo entries in the journal. ");
            return;
        }
        Console.WriteLine("\nJournal Entries: ");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine(new string('-', 100));
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.Response}");
            }
        }
        Console.WriteLine("Journal succssesfully saved! ");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. ");
            return;
        }

        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine().Split('|');
                JournalEntry entry = new JournalEntry
                {
                    Date = DateTime.Parse(parts[0]),
                    Prompt = parts[1],
                    Response = parts[2]
                };
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully! ");
    }
}