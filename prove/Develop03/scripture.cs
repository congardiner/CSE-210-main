using System;
using System.Security.Cryptography;

class Scripture 
{
    private string _verse;
    private string _scriptureText;
    private string _reference;
    private string _word;
// hold the scriptures here in a list


// here are my constructors //
private Scripture(string verse, string reference, string word)
{
    _verse = verse;
    _reference = reference;
    _word = word;
}

private static List<string> scriptures = new List<string>()
{
    "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.",
    "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.",
};

// a list to store the scripture itself, then split into reference and words, foreach for words.





public void DisplayScripture()
{
    Console.WriteLine($"Verse: {_verse}");
    Console.WriteLine($"Scripture Text: {_scriptureText}");
    Console.WriteLine($"Reference: {_reference}");
    Console.WriteLine($"Word: {_word}");

    // I think that I need to handle the objects separately within this code, so that it is passed in between. //
}


GetScriptureText();


}