using System.Data;

public class Reference
{
    //Private attributes (Encapsulation)
    private string _book;
    private int _chapter;
    private int _verseBegin;
    private int _verFinish;

    //First Constructor to handle single verse references (Mosiah 5:12)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseBegin = verse;
        _verFinish = verse;
    }
    //Second Constructor to handle multiple verses (Proverbs 3:5-6)
    public Reference(string book, int chapter, int verseBegin, int verseFinish)
    {
        _book = book;
        _chapter = chapter;
        _verseBegin = verseBegin;
        _verFinish = verseFinish;
    }

    //Methods

    public string GetDisplayText()
    {
        //If citation is a single verse format without hyphen
        if (_verseBegin == _verFinish)
        {
            return $"{_book} {_chapter}:{_verseBegin}";
        }
        else//If citation is larger than single verse, append ending verse with hyphen
        {
            return $"{_book} {_chapter}:{_verseBegin} - {_verFinish}";
        }
    }

}