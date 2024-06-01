using System;
using System.Collections.Generic;

class Scripture 
{
    // private list handled just within scripture //
    private List<Words> _listWords;

    // hold the scriptures here in a list // 
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

    
// this will actually then be put into my program class, so that this is handled as an object, similar to the reference class that I made. //

    public void HideWords(int count)
    {
        Random random = new Random();
        List<int> hiddenWordList = new List<int>();
        // before; condition; after as my notes say //
        for (int i=0; i < count; i++)
        {
            if (!_listWords[i].RevealWord)
            {
                hiddenWordList.Add(i);
            }
        }
        

        // module found for math that will assist in hidewords ensuring that they actually cycle through.
        int hidewords = Math.Min(count, hiddenWordList.Count);

        for (int i = 0; i < hidewords; i++)
        {
            // will iterate through the index until all of the words have been revealed. 
            int index = hiddenWordList[random.Next(hiddenWordList.Count)];

            // will call words of the index, reveal word called in word class?
            _listWords[index].RevealWordComplete();
            hiddenWordList.Remove(index);
        
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