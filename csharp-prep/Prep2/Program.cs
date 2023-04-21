using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you grade percentage?:");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade: {letter}");
        
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Keep trying!");
        }


    }
}