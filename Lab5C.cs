/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab5C
*/

using System;

class Lab5C
{

    public static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        int x= int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y= int.Parse(Console.ReadLine());
        if (x == 0 && y == 0)
        {
            Console.WriteLine("This point is the origin.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("This point is on the y axis.");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("This point is on the x axis.");
        }
        else if (x >= 0 && y >= 0)
        {
            Console.WriteLine("This point is in the first quadrant.");
        }
        else if (x <= 0 && y >= 0)
        {
            Console.WriteLine("This point is in the second quadrant.");
        }
        else if (x <= 0 && y <= 0)
        {
            Console.WriteLine("This point is in the third quadrant.");
        }
        else if (x >= 0 && y <= 0)
        {
            Console.WriteLine("This point is in the fourth quadrant.");
        }
       
    }
}
