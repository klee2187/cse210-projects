public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
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