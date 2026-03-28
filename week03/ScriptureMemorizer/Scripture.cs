using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rng = new Random();

    public Scripture(Reference reference, string passage)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = passage.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = _rng.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
            if (IsCompletelyHidden())
                break;
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " - ";

        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }

        return true;
    }
}