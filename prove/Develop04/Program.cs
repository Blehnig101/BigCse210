using System;

class Program
{
    static void Main(string[] args)
    {

        Animation animation = new Animation();
        // animation.GetAnimation();
        // Listeningact listeningact = new Listeningact();

        string userInput = "0";

        Console.WriteLine("Welcome to the meditation center");
        Console.WriteLine("What mode choose one of the 3 options.");
        Console.WriteLine("1 Breathing");
        Console.WriteLine("2 REflection");
        Console.WriteLine("3 listening");
        userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Breathingact.Exercise();
        }
        else if (userInput == "2")
        {
            Reflectionact.Exercise();
        }
        else if (userInput == "3")
        {
            Listeningact.Exercise();
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