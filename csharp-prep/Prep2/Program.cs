using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade percentage?: ");
        string userGrade = Console.ReadLine(); 

        int x = int.Parse(userGrade);

        if (x >= 90)
        {
            Console.Write("You earned a A!");
        }
        else if (x >= 80 && x <= 89)
        {
            Console.Write("You earned a B!");
        }
        else if (x >= 70 && x <= 79)
        {
            Console.Write("You earned a C!");
        }
        else
        {
            Console.Write("You didn't get a high enough grade to pass");
        }
    }
}