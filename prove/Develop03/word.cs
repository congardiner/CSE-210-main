using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


class Words 
{
    // encapsulates my instances using my private identifier. //
    private string _word;
    private string _hiddenWord;
    private bool _revealWord;

    // calls them locally within just this class. // 
    public Words(string word)
    {
        _word = word;
        _hiddenWord = new string('*', word.Length);
        _revealWord = false;
    }

    public string HiddenWord
    {
        get {return _hiddenWord; } 
    }

// this will be the section for the reveal, and need to create a method with objects that will sort through the words. 

    public bool RevealRandom
    {

        get { return _revealWord; }
        set
        {
            _revealWord = value;
            _hiddenWord = _revealWord ? _word : new string('*', _word.Length);
    
        }

    }

    // new operator(s) that I learned to use for boolean expressions: ! will reverse as null-forgiving, or the expression as true or false, dependent on the reversal being used. //
    public void RevealWord()
    {
        _revealWord = !_revealWord;
        _hiddenWord = _revealWord ? _word : new string('*', _word.Length);
    }

  

}
    // will put each of the list of strings into words. //


        
        // before; condition; after

        // this will be for iterating through each of the words, 3 at a time until all are hidden. //



        // need to update this seciton so that it will actually hide and then revel a word with a test case. //

