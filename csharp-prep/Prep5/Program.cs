using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        string DisplayWelcome(string welcome)
        {
            Console.WriteLine($"Hello, welcome to the Program!");
        }

        string PromptUserName(string userName)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, "+ name +"!Welcome to the Program!");
            Console.WriteLine($"Also glad to hear that your favorite number is {favNumber}.");
        }

        string PromptUserNumber(int favNumber)
        {
            Console.WriteLine("What is your favorite number? ");
            string numfav = Console.ReadLine();

            Console.WriteLine("Oh so your favorite number is"+ numfav +"how exciting.");
        }
    }
}