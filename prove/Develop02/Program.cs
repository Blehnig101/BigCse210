using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Entry e = new Entry();
        // e._userPrompt = "I don't like this";
        // e._dateTime = "04/01/2003";
        // e._userEntry = "this is the enty";
        // e.Display();
        // return;

        int userInput = 0;
        Journal saveEntries = new Journal();

        do
        {
            Console.WriteLine("Wecome to your personal electronic journal!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Prompt prompt1 = new Prompt();
                string onePrompt = prompt1.Display();
                Console.WriteLine($"Your prompt is: {onePrompt}");
                string userEntry = Console.ReadLine();
                Entry e = new Entry();
                e._userPrompt = onePrompt;
                DateTime theCurrentTime = DateTime.Now;
                e._dateTime = theCurrentTime.ToShortDateString();
                e._userEntry = userEntry;
                saveEntries._savedEntries.Add(e);
            }

            else if (userInput == 2)
            {
                Console.WriteLine("Answers entered:");
                foreach (Entry e in saveEntries._savedEntries)
                {
                    e.Display();
                }

            }

            else if (userInput == 3)
            {
                Console.Write("Please enter your file name: ");

                string name = Console.ReadLine();

                string filename = name + ".txt";

                saveEntries.NewJournalFromFile(filename);
                

            }

            else if (userInput == 4)
            {
                Console.Write("Please enter your file name: ");

                string name = Console.ReadLine();

                string filename = name + ".txt";

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    // You can add text to the file with the WriteLine methodS
                    foreach (Entry e in saveEntries._savedEntries)
                    {
                        outputFile.WriteLine($"{e._dateTime}~{e._userPrompt}~{e._userEntry}");
                    }

                    // You can use the $ and include variables just like with Console.WriteLine
                }

            }

            else if (userInput == 5)
            {
                Console.WriteLine("Print 5");
            }

            else
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }

        } while (userInput != 5);


    }
}