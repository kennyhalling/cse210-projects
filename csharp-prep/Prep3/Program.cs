using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        do
        {

            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(0,101);

            string correct = "no";
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess?: ");
                int answer = int.Parse(Console.ReadLine());
                guessCount = guessCount+1;
                if (answer > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                if (answer < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                if (answer == magicNum)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Guesses Made: {guessCount}");
                    correct = "yes";
                }
            } while (correct == "no");

            Console.Write("Would you like to play again?: ");
            playAgain = Console.ReadLine();

        } while (playAgain.ToLower() == "yes");
    }
}