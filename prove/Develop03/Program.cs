using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        ScriptureFile file = new ScriptureFile();
        file.ReadFile();

        Scripture scripture = null;

        Console.WriteLine("Welcome to the scripture memorization program!");
        Console.WriteLine("Let's get started!");

        KeyValuePair<string, string> randomScripture = file.PickRandomScripture();

        scripture = new Scripture(randomScripture.Key, randomScripture.Value);
        scripture.DisplayScripture();

        string userInput;

        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to end program:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords();

                if (scripture.AllHidden())
                
                { 
                    break;
                }

                Console.Clear();
                scripture.DisplayScripture();
            }
        }
        while (userInput != "quit");
        scripture.DisplayIntactScripture();
    }
}