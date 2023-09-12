/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab5A
*/

using System;

class Lab5A
{

    public static void Main(string[] args)
    {
        Console.Write("Do you have a driving permit (Y/N)? ");
        char permit = char.Parse(Console.ReadLine());
        if(permit == 'Y'||permit=='y')
        {
            Console.Write("Do you have a commercial driving license (Y/N)? ");
            char license=char.Parse(Console.ReadLine());
            if (license == 'Y' || license == 'y')
            {
                Console.WriteLine("Congratulations! You can purchase a vehicle, let's start talking options!");
            }
            else
            {
                Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle!");
            }
        }
        else
        {
            Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle!");
        }
    }
}
