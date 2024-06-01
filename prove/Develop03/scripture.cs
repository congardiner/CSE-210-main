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
        List<int> hiddenWordCycle = new List<int>();
        // before; condition; after as my notes say //
        for (int i = 0; i < _listWords.Count; i++)
        {
            if (!_listWords[i].IsHidden)
            {
                hiddenWordCycle.Add(i);
            }
        }

        // module found for math that will assist in hidewords ensuring that they actually cycle through. //
        // 
        int wordsToHide = Math.Min(count, hiddenWordCycle.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = hiddenWordCycle[random.Next(hiddenWordCycle.Count)];
            _listWords[index].HideWord();
            hiddenWordCycle.Remove(index);
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
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}
