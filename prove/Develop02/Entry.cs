using System;

public class Entry
{

    public string _dateText;
    public string _userEntry;
    public string _showPrompt;

    
    
    public Entry()
    {
        DateTime currentTime = DateTime.Now;
        _dateText = currentTime.ToShortDateString();
        Prompt getPrompt = new Prompt();
        _showPrompt = getPrompt.GeneratePrompt();
        Console.WriteLine(_showPrompt);
        _userEntry = Console.ReadLine();
       
    }

    public Entry(string dateText, string showPrompt, string userEntry)
    {
        _dateText = dateText;
        _showPrompt = showPrompt;
        _userEntry = userEntry;
        
    } 

    public void DisplayEntry()
    {
        Console.WriteLine($"{_dateText}");
        Console.WriteLine($"Prompt: {_showPrompt}");
        Console.WriteLine($"{_userEntry}");
    }


}