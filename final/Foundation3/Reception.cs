using System.ComponentModel.DataAnnotations;

public class Reception : Event
{
    
    private string _email;
    
    public Reception(string type, string title, string description, string date, string time, Address address, string email) : base(type, title, description, date, time, address)
    {
        _email = email;
    }

    public override void DisplayAllDetails()
    {   
        DisplayStandardDetails();
        
        Console.WriteLine($"You have been cordially invited to attend the {GetEventType()} of two people who have decided to begin their life together.");
        Console.WriteLine($"Here are the details of this very special occasion:\n");
        Console.WriteLine($"{GetTitle()}\n");
        Console.WriteLine($"{GetDescription()}\n");
        Console.WriteLine($"{GetDate()} {GetTime()}");
        Console.WriteLine($"{GetAddress()}\n");
        Console.WriteLine($"Please RSVP your attendance at {_email}");

        DisplayShortDescription();
    }

    
}