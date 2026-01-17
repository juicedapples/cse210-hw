using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.\n");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.Display());
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            int index = 0;
            while (index < lines.Length)
            {
                Entry entry = Entry.FromFileString(lines[index]);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
                index++;
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
//Completed for new term
