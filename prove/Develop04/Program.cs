using System;

class Program
{
    static void Main(string[] args)
    {

        Animation animation = new Animation();
        // animation.GetAnimation();

        string userInput = "0";

        Console.WriteLine("Welcome to the meditation center");
        Console.WriteLine("What mode choose one of the 3 options.");
        Console.WriteLine("1 Breathing");
        Console.WriteLine("2 REflection");
        Console.WriteLine("3 listening");
        userInput = Console.ReadLine();

        if (userInput == "1")
        {

        }
        else if (userInput == "2")
        {

        }
        else if (userInput == "3")
        {
            
        }
        else if (userInput == "quit")
        {
            Console.WriteLine("You have quit the program.");
        }
        else
        {
            Console.WriteLine("Please choose a actual option.");
        }


        
    }
}