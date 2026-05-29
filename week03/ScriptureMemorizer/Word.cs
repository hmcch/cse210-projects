using System.Reflection.Metadata;

public class Word

{
    //Private Attributes (Encapsulation)
    //Only Word Class can see/alter these attributes
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }
    //Methods
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            //Dynamic underscore
            //The exact character count matches the character length of the hidden word
            return new string('_', _text.Length);
        }
        return _text;
    }
}