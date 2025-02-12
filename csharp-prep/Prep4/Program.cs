using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number (0 to quit)");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        }
        // this is the code for the calculations
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"This is the sum {sum}");

        //This is the code for getting the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"This is the average {average}");

        // This is the code for the Max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"This is the max {max}");

    }
}