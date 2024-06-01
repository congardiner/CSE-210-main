using System;
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
        _hiddenWord = new string('_', word.Length);
        _revealWord = false;
    }

    public string HiddenWord
    {
        get {return _revealWord ? _word : _hiddenWord; } 
    }

    // this will be the section for the reveal, and need to create a method with objects that will sort through the words. 

    public bool RevealWord
    {
        get {return _revealWord; }
    }

    // new operator(s) that I learned to use for boolean expressions: ! will reverse as null-forgiving, or the expression as true or false, dependent on the reversal being used. //
   public void RevealWordComplete()
   {
        _revealWord = true;
        _hiddenWord = _word;
   }

}
    // will put each of the list of strings into words. //

    // this will be for iterating through each of the words, 3 at a time until all are hidden. //

    // need to update this seciton so that it will actually hide and then reveal a word with a test case. //

