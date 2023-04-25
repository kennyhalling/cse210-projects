using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PrompUserNumber();
        int square = SquareNumber(userNum);
        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PrompUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }
    static int SquareNumber(int number)
    {
        int square = number*number;
        return square;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}