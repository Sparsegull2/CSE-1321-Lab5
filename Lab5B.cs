/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab5B
*/

using System;

class Lab5B
{

    public static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int input= int.Parse(Console.ReadLine());
        switch (input%2)
        {case 0:
            Console.WriteLine("This number is divisible by 2");
                break;
            default:
                switch(input%3) {
                    case 0: Console.WriteLine("This number is divisible by 3");
                        break;
                    default:
                        switch(input%5) {
                            case 0: Console.WriteLine("This number is divisible by 5");
                        break;
                                default:
                                Console.WriteLine("This number is undetermined");
                                break;
                        }
                        break;
                                        }break;
            

        }
            }
}
