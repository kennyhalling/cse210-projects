// Journal:
//   -Displays menu that user can interact with in order to access different parts
//       of their virtual journal
//   -Attributes:
//       -_userChoice string
//       -_journalEntriesList string
//   -Behaviors:
//       -SaveFile()
//       -LoadFile()
//       -NewEntry()
//       -Display()

public class Journal
{
    public void JournalMenu()
    {
        Console.Write(@"Welcome to your virtual journal!
        Please select one of the following choices: 
        1. Write New Entry
        2. Display Journal
        3. Load Journal
        4. Save Journal
        5. Exit Program
        What would you like to do?: ");
        int _userChoice = int.Parse(Console.ReadLine());
        if (_userChoice == 1)
        {}
        if (_userChoice == 2)
        {}
        if (_userChoice == 3)
        {}
        if (_userChoice == 4)
        {}
        if (_userChoice == 5)
        {}
    }

    public Journal()
    {}
}