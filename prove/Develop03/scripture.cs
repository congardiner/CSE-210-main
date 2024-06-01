using System;
using System.Collections.Generic;

class Scripture 
{
    // private list handled just within scripture //
    private List<Words> _listWords;

    public Scripture(string scripture)
    {
        _listWords = new List<Words>();
        var wordsArray = scripture.Split(' ');
        // array made for each word to be stored //
        foreach (var word in wordsArray)
        {
            _listWords.Add(new Words(word));
        }
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        List<int> hiddenWordIndices = new List<int>();
        // before; condition; after as my notes say //
        for (int i = 0; i < _listWords.Count; i++)
        {
            if (!_listWords[i].RevealWord)
            {
                hiddenWordIndices.Add(i);
            }
        }

        // module found for math that will assist in hidewords ensuring that they actually cycle through. //

        int wordsToHide = Math.Min(count, hiddenWordIndices.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = hiddenWordIndices[random.Next(hiddenWordIndices.Count)];
            _listWords[index].RevealWordComplete();
            hiddenWordIndices.Remove(index);
        }
    }

    public string GetScripture()
    {
        List<string> words = new List<string>();
        foreach (var word in _listWords)
        {
            words.Add(word.HiddenWord);
        }

        return string.Join(" ", words);
    }



    public bool ProgramComplete()
    {
        foreach (var word in _listWords)
        {
            if (!word.RevealWord)
            {
                return false;
            }
        }
        return true;
    }
}


// here are my constructors //

// a list to store the scripture itself, then split into reference and words, foreach for words.

// just will handle a list of the scriptures and then send it to the Program. 