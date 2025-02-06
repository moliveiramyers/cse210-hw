using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _usa;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _usa = false;
    }

    public string GetStreet()
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

    public string GetCountry()
    {
        return _country;
    }

    public bool usaIdentifier()
    {
        if (_country == "USA")
        {
            _usa = true;
        }
        else
        {
            _usa = false;

        }
        return _usa;
    }

    public string GetDisplay()
    {
        return $"{_street}, {_city}, {_state} - {_country}.";
    }
}