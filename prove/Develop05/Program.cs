using System;

class Program
{
    static void Main(string[] args)
    {

        string userInput = "0";

        while (userInput != "6")
        {
            Console.WriteLine("Welcome to the goal tracking app");
            Console.WriteLine("Which would you like to choose");
            Console.WriteLine("1 display score.");
            Console.WriteLine("2 new goal");
            Console.WriteLine("3 record");
            Console.WriteLine("4 save");
            Console.WriteLine("5 load");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Tracker.Display();
            }
            else if (userInput == "2")
            {
                Tracker.Addgoal();
            }
            else if (userInput == "3")
            {
                Tracker.Record();
            }
            else if (userInput == "4")
            {
                Tracker.Save();
            }
            else if (userInput == "5")
            {
                Tracker.GetFile();
            }
        }


        
    }
}