using System;
using System.Collections.Generic;

public class Scripture
{
    //Private attributes
    //Maintains this data hidden from Program.cs
    private Reference _reference;
    private List<Word> _words;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split the main text block by using blank spaces and construct individual words
        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    //Methods

    //Select randomly and hide a certain amount of current visible words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();

        }
    }


    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (var word in _words)
        {
            result += word.GetDisplayText() + " ";

        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}