using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Making Progress Starts Here!");
            Console.WriteLine("The Eternal Quest: Its Eternal");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Save Goal(s)");
            Console.WriteLine("5. Load Goal(s)");
            Console.WriteLine("6. Exit Program");

            Console.WriteLine("Enter Your Choice");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    simple.AddActivity();
                    break;

                case "2":
                    eternal.AddActivity();
                    break;

                case "3":
                    checklist.AddActivity();
                    break;
                case "4":
                    
                    // add save file method //
                    break;
                
                case "5":
                    // add load file of goals //
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("This is not a valid response. Please enter either 1, 2, 3, 4, 5, or 6 to use the application. Enter 6 to exit completely.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to enter the menu, or startup the program please!");
                Console.ReadKey();
            }
        }

        // I am going to add Display methods for the polymorphic methods and their respective classes. //

        // add Display method for score, list of goals, and 
    }
}