using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {


        // scripture.HideEverything();
        // Console.WriteLine(scripture.GetScripture());

        
        // Console.WriteLine(reference.GetReference());



        // Word word = new Word("behold");
        // Console.WriteLine(word.GetWord());
        // word.HiddenWord();
        // Console.WriteLine(word.GetWord());
        Reference reference = new Reference("Daniel", 3, 18);

        Scripture scripture = new Scripture(reference,"But if not, be it known unto thee, O king, that we will not serve thy gods, nor worship the golden image which thou hast set up.");


        string userChoice = "";
        Console.WriteLine("Choose one of the following modes");
        Console.WriteLine("type 1 for Easy");
        Console.WriteLine("type 2 for medium");
        Console.WriteLine("type 3 for hard");
        userChoice = Console.ReadLine();



        do 
        {
            // This will clear the console
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            
            Console.WriteLine("Please press enter to continue the hid the scripture.");
            Console.Write("Type quit anytime to exit: ");
            userChoice = Console.ReadLine();
            

            if (scripture.IsEvertthing())
            {
                break;
            }

            scripture.HideWord();

        } while (userChoice != "quit");

            
    }
}