using System.Security.Cryptography.X509Certificates;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    private string _subject;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacity, string subject) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _subject = subject;

    }

    public override void DisplayAllDetails()
    {
        DisplayStandardDetails();

        Console.WriteLine($"We are pleased to have {_speaker} come and and give a {GetEventType()} about {_subject}.\n");
        Console.WriteLine("Event Details:");
        Console.WriteLine($"\n{GetTitle()}\n");
        Console.WriteLine($"{GetDescription()}\n");
        Console.WriteLine($"{GetDate()}\n{GetTime}");
        Console.WriteLine($"{GetAddress()}\n");
        Console.WriteLine($"Get your tickets soon as there will only be {_capacity} available");

        DisplayShortDescription();
    }
}