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

    public string DisplayAddress()
    {
        string address = $"\n{_street}\n{_city}, {_state} {_zip}\n{_country}"; 
        return address; 

    }

}