using System;
using System.IO;


class Program
{

    static void Main(string[] args)
    {   
       
        Prompt prompt = new Prompt();
        Journal journal = new Journal();
        
        
        Console.WriteLine("Hello! Welcome to the journal program!");
        int choice;

        do
        {
            journal.DisplayMenu();
            choice = journal._userChoice;

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.DisplayEntry();
                journal._journal.Add(entry);

                
            }
            
            else if (choice == 2)
            {
                journal.DisplayJournal();
            }

            else if (choice == 3)
            {
                string file = journal._userFile;
                List<Entry> savedEntries = journal.LoadEntryFromFile();

                foreach (Entry entry in savedEntries)
                {
                    journal._journal.Add(entry);
                }
            }

            else if (choice == 4)
            {
                journal.SaveEntryToFile(journal._journal);
                string file = journal._userFile;
            }

            else
            {
                Console.WriteLine("See you next time!");
            }

            
        } while (choice != 5);
    }

}

