using System;
using System.ComponentModel.DataAnnotations;


class Words 
{
    private string _word;
    private string _hiddenWord;
    private bool _revealSection;

    public Words(string word)
    {

        _word = word;
        _hiddenWord = new string('*', word.Length);
        _revealSection = false;
    }

    public string HiddenWord
    {
        get {return _hiddenWord; } 
    }



    public string RevealRandom(bool _revealSection)
    {
        if (!_revealSection)
        {
            _hiddenWord = new string('*', _word.Length);
            _revealSection = false;
            return;
        }

        // need to update this seciton so that it will actually hide and then revel a word with a test case. //

        

    }

    public string RevealWord()
    {
        return _word;
    }
   
    // handle with true or false statements, 3 words at a time. //

}