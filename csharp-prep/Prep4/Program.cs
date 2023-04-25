using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Boolean getNumbers = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (getNumbers)
        {
            Console.Write("Enter Number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                getNumbers = false;
            }
            else
            {
                numbers.Add(newNumber);
            }
        }

        int sum = 0;
        int largest = 0;

        foreach (int number in numbers)
        {
            sum = sum+number;
            if (number > largest)
            {
                largest = number;
            }
        }
        int length = numbers.Count;
        float average = ((float)sum)/length;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}