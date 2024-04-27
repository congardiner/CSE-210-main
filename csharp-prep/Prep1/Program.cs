using System;
using System.Net.WebSockets;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstcg = Console.ReadLine();
        // Console.WriteLine($"Your first name is {firstcg}.");

        Console.Write("What is your last name? ");
        string lastcg = Console.ReadLine();
        // Console.WriCteLine($"Your last name is {lastcg}.");
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastcg}, {firstcg} {lastcg}.");

    }
}