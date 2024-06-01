using System;
class Scripture 
{
    private List<Words> _listWords;

    // hold the scriptures here in a list
    public Scripture(string scripture)
    {
        _listWords = new List<Words>();
        var wordsArray = scripture.Split(' ');
        foreach (var word in wordsArray)
        {
            _listWords.Add(new Words(word));
        }
    }

    
// this will actually then be put into my program class, so that this is handled as an object, similar to the reference class that I made. //
// holding

    public void HideWords(int count)
    {
        Random random = new Random();
        for (int i=0; i < count; i++)
        {
            int index = random.Next(_listWords.Count);
            _listWords[index].RevealWord();
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

}

// here are my constructors //

// a list to store the scripture itself, then split into reference and words, foreach for words.

// just will handle a list of the scriptures and then send it to the Program. 