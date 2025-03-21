using System;
using System.Xml.Serialization;
class Tracker 
{
    private static List<Goal>Goallist = new List<Goal>();

    private static int totalpoints = 0;

    public static void GetFile()
    {
        Console.WriteLine("What is the name of your file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        totalpoints = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("-",2);

            string goaltype = parts[0];
            string goaldata = parts[1];
            switch (goaltype)
            {
                case "Simple":
                    Simple simple = new Simple(goaldata);
                    Goallist.Add(simple);
                    break;
                case "Checklist":
                    Checklist checklist = new Checklist(goaldata);
                    Goallist.Add(checklist);
                    break;
                // case "Eternal":


            }


        }
    }

    public static void Addgoal()
    {
        Console.WriteLine("What goal do you want? ");
        Console.WriteLine("1 simple goal ");
        Console.WriteLine("2 checklist goal ");
        Console.WriteLine("3 Eterenal goal ");
        int goaltype = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of the Goal");
        string goalname = Console.ReadLine();
        Console.WriteLine("What is the destription of the Goal");
        string destrip = Console.ReadLine();
        Console.WriteLine("What is are the points of the Goal");
        int goalpoints = int.Parse(Console.ReadLine());

        if (goaltype == 1)
        {
            Simple simple = new Simple(false, goalpoints, destrip, goalname);
            Goallist.Add(simple);
        }
        else if (goaltype == 2)
        {
            Console.WriteLine("how many bonuspoints do you wnat?");
            int bonuspoints = int.Parse(Console.ReadLine());
            Console.WriteLine("What are the total amount of times you want? ");
            int totaltimes = int.Parse(Console.ReadLine());    
            Checklist checklist = new Checklist(bonuspoints, totaltimes, goalpoints, destrip, goalname);
            Goallist.Add(checklist);
        }
        else if (goaltype == 3)
        {
            Eterenal eternal = new Eterenal(goalpoints, destrip, goalname);
            Goallist.Add(eternal);            
        }
    }

    public static void Display()
    {
        Console.WriteLine(totalpoints);

        foreach(Goal goal in Goallist)
        {
            goal.Display();

        }
    }
    
    public static void Record()
    {
        Display();

        Console.WriteLine("What goal do you want to complete? ");
        int recordevent = int.Parse(Console.ReadLine());

        int index = recordevent -1;

        int points_earned = Goallist[index].Record();

        totalpoints += points_earned;
    }

    public static void Save()
    {
        Console.WriteLine("What is the name of the file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalpoints);

            foreach (Goal goal in Goallist)
            {
                outputFile.WriteLine(goal.Save());
            }
            // You can add text to the file with the WriteLine method

            

        }
    }
}