using System;
using System.IO;


class Journal
{   public string _userFile;
    public int _userChoice;
    public List<string> _menu = new List<string>()
    {
        "Write",
        "Display",
        "Load",
        "Save",
        "Quit"
    };
    public List<Entry> _journal = new List<Entry>();

    public void SaveEntryToFile(List<Entry> journal)
    {
        Console.Write("What file would you like to save your journal to? ");
        _userFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_userFile))
        {
            foreach (Entry entry in journal)
            {
                outputFile.WriteLine($"{entry._dateText} | {entry._showPrompt} | {entry._userEntry}");
            }
        }
    }

    public List<Entry> LoadEntryFromFile()
    {
        List<Entry> journal = new List<Entry>();

        Console.Write("Please type in your file name: ");
        _userFile = Console.ReadLine();

        string[] entries = System.IO.File.ReadAllLines(_userFile);

        foreach (string entry in entries)
        {
            string[] lines = entry.Split(" | ");

            Entry newEntry = new Entry(lines[0], lines[1], lines[2]);
            journal.Add(newEntry);       
        }

        return journal;

    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please choose one of the following options:");

        for (int i = 0; i < _menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_menu[i]}");
        }

        Console.Write("Type the number of the corresponding action you would like to complete: ");
        _userChoice = int.Parse(Console.ReadLine());
        
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }
    }
}