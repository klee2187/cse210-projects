public class Address 
{
private string _street;
private string _city;
private string _state;
private int _zip;

public Address(string street, string city, string state, int zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}\n{_city}, {_state} {_zip}");
    }
}