using System;
using System.Collections.Generic;

class Words 
{
    // encapsulates my instances using my private identifier. //
    private string _word;
    private string _hiddenWord;
    private bool _ishidden;

    // calls them locally within just this class. // 
    public Words(string word)
    {
        _word = word;
        _hiddenWord = new string('_', word.Length);
        _ishidden = false;
    }

    public string HiddenWord => _ishidden ? _hiddenWord : _word;

    public bool IsHidden => _ishidden;

    // new operator(s) that I learned to use for boolean expressions: ! will reverse as null-forgiving, or the expression as true or false, dependent on the reversal being used. //
   public void HideWord()
   {
        _ishidden = true;
   }

}
    // will put each of the list of strings into words. //

    // this will be for iterating through each of the words, 3 at a time until all are hidden. //

    // need to update this seciton so that it will actually hide and then reveal a word with a test case. //

