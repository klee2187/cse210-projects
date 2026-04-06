public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string type, string title, string description, DateOnly date, TimeOnly time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        throw new NotImplementedException();
    }

    public override string ShortDescription()
    {
        throw new NotImplementedException();
    }
}