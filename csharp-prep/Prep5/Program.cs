using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, SquaredNumber);

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello, welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int numfav = int.Parse(Console.ReadLine());

        return numfav;
    }

    static int SquareNumber(int numfav)
    {
        int square = numfav * numfav;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
         Console.WriteLine($"{name} Oh so your favorite number that has been squared is {square}, how exciting!");
         Console.WriteLine("Next time you should try a different number, and see how it works out!");
    }
}