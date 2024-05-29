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

// a list to store the scripture itself, then split into reference and words, foreach for words.
// ether 12:4



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