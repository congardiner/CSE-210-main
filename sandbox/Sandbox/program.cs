using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Program
{
        static void Main(string[] args)
        {
                string greeting = "Welcome to shape calculator";
                Console.WriteLine($"{greeting}");

                List<RoundShape> myList = new List<RoundShape>();

                myList.Add(new Circle(1.0));
                myList.Add(new Cylinder(1.0, 2.0));
                myList.Add(new Sphere(2.0));


                foreach (RoundShape shape in myList)
                {
                        Console.WriteLine(shape.Area());
                }

        }



}