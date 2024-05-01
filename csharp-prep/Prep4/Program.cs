using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> numbers = new List<string>();

        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        string input;
        while ((input = Console.ReadLine()) != "0")

        {
            numbers.Add(input);
        }

        Console.WriteLine("Enter a number: ");

        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        int sum = NumberSum(numbers);

        Console.WriteLine("The Sum is: " + sum);

        Console.WriteLine("The average is: ");

        Console.WriteLine("The largest number is: ");






        Console.WriteLine("Would you like to see an additional program that I made for practice in learning these concepts?");

        Console.WriteLine("Prep Number 4 practice file that I created!");

        List<string> phones = new List<string>();

        phones.Add("Samsung");
        phones.Add("Apple");
        phones.Add("Google");
        phones.Add("Motorola");
        phones.Add("Oneplus");

        Console.WriteLine(phones.Count);

// this will iterate through the list, using the foreach function...

        foreach (string phone in phones)
        {
            Console.WriteLine(phone);
        }

// or I could access this using the index

        for (int i = 0; i < phones.Count; i++)
        {
            Console.WriteLine(phones[i]);
        }

        


    }
}