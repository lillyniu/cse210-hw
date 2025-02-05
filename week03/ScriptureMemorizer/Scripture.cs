using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' '); 
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display(bool showHint = false)
    {
        try
        {
            Console.Clear();
        }
        catch (Exception)
            {
                Console.WriteLine("An error occured");
            }


        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
            {
            Console.Write(word.GetText() + " ");
            }

        Console.WriteLine();
    }

    public void HideRandomWords(int count, bool hideOnlyVisible = true)
    {
        Random random = new Random();

        for (int i=0; i < count; i++) 
        {
            List<Word> wordsToHide = new List<Word>();

            foreach (Word word in _words)
            {
                if (!hideOnlyVisible || !word.Hidden())
                {
                    wordsToHide.Add(word);
                }
            }

            if (wordsToHide.Count == 0)
            {
                break;
            }

            int index = random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();

        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
            {
                return false;
            }
        }
        return true;
    }
}