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
            Console.WriteLine("4. Save Goal");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit Program");

            Console.WriteLine("Enter Your Choice");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    break;

                case "2":
                    
                    break;

                case "3":
                    
                    
                    break;
                case "4":

                    break;
                
                case "5":

                    break;
                    
                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("This is not a valid response. Please enter either 1, 2, or 3 to use the application. Enter 4 to exit the program.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to enter the menu, or startup the program please!");
                Console.ReadKey();
            }
        }
    }
}