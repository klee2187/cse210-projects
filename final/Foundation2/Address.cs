using System.Security.Authentication;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;

    public Address(string street, string city, string state, int zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string SetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public int GetZip()
    {
        return _zip;
    }

    

    public bool GetIsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }    
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}\n{_city}, {_state} {_zip}\n{_country}");  

    }

}