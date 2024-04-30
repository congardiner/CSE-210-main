using System;
using System.Security.Cryptography.X509Certificates;

class Program

{
    static void Main(string[] args)
    {
        int x=0;

        if (x==0)
        {
            Console.WriteLine("testing code.");
        }

        while (x<3)
        {
            Console.WriteLine("H.W.");
            x += 1;
            // x -= 1;
            // x *= 1;
            // x %= 1;
            // x /= 1;
        }

        // for x in range(9): print("Hello World") this is how it is done within python

        for (int x=0; x<9; x++)
        {
            Console.WriteLine("Howdy Sandbox World!");
        }




    }
}