using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicnumber = random.Next(1, 11);

        bool playagain = true;

        Console.WriteLine("Welcome to my random number guessing game!");

        Console.WriteLine("You will be able to guess a number chosen at random between 1-10, in this version you have unlimited attempts!");

    while (playagain)
    {
        // Console.WriteLine("What is the magic number? ");
        // int magicnumber = int.Parse(Console.ReadLine());
        // 

        Console.WriteLine("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

// could make it so that they have a limited number of guesses
// use a while loop so that while they are within this script, they are stuck until the conditions are met.

    
        if (guess > magicnumber)
        {
            Console.WriteLine("Lower!");
        }

        else if (guess < magicnumber)
        {
            Console.WriteLine("Higher!");
        }

        else
        {
            Console.WriteLine("You guessed it right!");
            playagain = false;
        }
    }
        // to put something in a list, you use .add() to add something to a list.

    if (playagain)
    {
        Console.WriteLine("Would you like to play the game again? (yes or no)");
        string playthrough = Console.ReadLine().ToLower();
   
        if (playthrough != "yes")
        {
            playagain = false; 
            Console.WriteLine("Thank you for playing the game! Lets get started!");
        }

        else
        {
            Console.WriteLine("That is not a proper response, 'yes' or 'no' are the two options.");
        }

    }
    
    }
}


// while

// do-while -- the body of the loop is guaranteed to run at least once because it doesn't check to see if the conditions work or match correctly (not in python)

// an example of this in action:

// string response;
// do
//{
// Console.Write("Do you want to continue? "):
// response = Console.ReadLine();
//} while (response == "yes");


// for 

// 1) intializes the value 2) condition to check and 3) increment step to run at the end of each loop
// there are 3 parts to writing for loops in csharp!
// for (int i = 0; i < 10; i++)
//{ Console.WriteLine(i); }





//foreach

// string response = "yes";

// while (response == "yes")
// {
    // Console.Write("Do you want to continue?");
//  }


