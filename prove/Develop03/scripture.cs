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
    Verse = verse;
    Reference = reference;
    Word = word;

}


public void DisplayScripture()
{
    Console.WriteLine($"Verse: {Verse}");
    Console.WriteLine($"Scripture Text: {scriptureText}");
    Console.WriteLine($"Reference: {reference}");
    Console.WriteLine($"Word: {word}");

    // I think that I need to handle the objects separately within this code, so that it is passed in between. //
}


GetScriptureText();


}