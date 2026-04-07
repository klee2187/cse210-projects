public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string type, string title, string description, string date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayAllDetails()
    {
        Console.WriteLine("\nOutdoor Gathering Standard Details:\n");
        DisplayStandardDetails();

        Console.WriteLine("\nOutdoor Gathering Full Details:\n");
        Console.WriteLine($"Come enjoy some fresh air at this {GetEventType()}!\n");
        Console.WriteLine($"Event Details:");
        Console.WriteLine($"{GetTitle()}\n");
        Console.WriteLine($"{GetDescription()}\n");
        Console.WriteLine($"{GetDate()}\n{GetTime()}");
        Console.WriteLine($"{GetAddress()}\n");
        Console.WriteLine($"The weather forecast is {_weather}");

        Console.WriteLine("\nOutdoor Gathering Short Description:\n");
        DisplayShortDescription();
    }


}