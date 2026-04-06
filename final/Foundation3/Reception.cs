using System.ComponentModel.DataAnnotations;

public class Reception : Event
{
    
    private EmailAddressAttribute _email;
    
    public Reception(string type, string title, string description, DateOnly date, TimeOnly time, Address address, EmailAddressAttribute email) : base(type, title, description, date, time, address)
    {
        _email = email;
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