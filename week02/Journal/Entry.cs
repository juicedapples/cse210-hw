using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    private string _date;;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public string Display()
    {
        return $"Date: {_date} - Prompt: {_promptText}\n{_entryText}";
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}