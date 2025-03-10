class Activity 
{   
    protected string _name;
    
    protected string _description;

    protected int _durration; 

    protected void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to the Activity!");
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("This is the end of the Activity!");
    }

        protected static int RunTime()
    {

        Console.WriteLine("Please enter a amount of time: ");
        int runtime = int.Parse(Console.ReadLine());

        return runtime;

    }

}