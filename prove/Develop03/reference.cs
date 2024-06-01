using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

    public string Book
    {
        get { return _book; }
        private set { _book = value; }
    }

    public int Chapter 
    {
        get { return _chapter; }
        private set { _chapter = value; }
    }

    public int FirstVerse
    {
        get { return _firstVerse; }
        private set { _firstVerse = value; }
    }

    public int SecondVerse 
    {
        get { return _secondVerse; }
        private set { _secondVerse = value; }
    }

// need to add all of the getters and setters to the program so that it is encapsulated correctly // 
    // this 
    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = 0;
    }

    // this is for the handling of multiple verses //
    public Reference(string book, int chapter, int firstVerse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = secondVerse;
    }

    public string GetScriptureReference()
    {
        if (_secondVerse > 0)
        {
            return $"{_book} {_chapter}: {_firstVerse} - {_secondVerse}";
        }
        else 
        {
            return $"{_book} {_chapter}: {_firstVerse}";
        }
    }
    // the scripture reference will hold the book, chapter, and use it for verses. // 

}