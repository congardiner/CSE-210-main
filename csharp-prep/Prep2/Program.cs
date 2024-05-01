using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string usercg = Console.ReadLine();
        Console.WriteLine("");
        
        string lettercg;

        if (double.TryParse(usercg, out double gradepercentcg))
        {
            if (gradepercentcg >= 90)
            {
                lettercg = "A";
                Console.WriteLine($"Your percentage of {gradepercentcg} Grade Percentage was more than 90%, so you got an A!");
            }

            else if (gradepercentcg >= 80)
            {
                lettercg = "B";
                Console.WriteLine($"Your percentage of {gradepercentcg} Grade Percentage was more than 80%, so you got an B!");
            }

            else if (gradepercentcg >= 70)
            {
                lettercg = "C";
                Console.WriteLine($"Your percentage of {gradepercentcg} Grade Percentage was more than 70%, so you got an C!");
            }

            else if (gradepercentcg >= 60)
            {
                lettercg = "D";
                Console.WriteLine($"Well you did it, just barely getting a percentage of {gradepercentcg}, with a D! This isn't enough to pass the course, but you will still receive credit.");
            }

            else
            {
                lettercg = "F";
                Console.WriteLine($"Unfortunately with your grade percentage of {gradepercentcg}, this is not a passing grade. Retake or remedial is now necessary!");
            }

            Console.WriteLine($"The Letter Earned for this course is the following: {lettercg} all due to the work that you put in!");
        }
        
        else
        {
            Console.WriteLine("Try again with your input, as this appears to not be a valid number, or in the correct notation for my basic program.");
        }
    }
    
}



//practice from my notes to review and learn

// for if statements:

// if (x < y)
// { Console.WriteLine("Less than");}

// use if, else if, and else, not elif in c sharp!

// review != is the notation for not equal, all others are still used the same like in python.

// We do the || for the OR operator? Interesting.

// && this is for the AND operator? What??


   //    Console.WriteLine("");
//   //    Console.Write("Write me a numerical value: ");
   //    string inputvaluecg = Console.ReadLine();
////   //    int x = int.Parse(inputvaluecg);
   //    int y = 2;
//   //    if (x > y)
   //    {
   //        Console.WriteLine("Greater");
   //    }
   //    else if (x < y)
   //    {
   //        Console.WriteLine("Less");
   //    }
   //    else
   //    {
   //        Console.WriteLine("Not Greater");
   //    }


