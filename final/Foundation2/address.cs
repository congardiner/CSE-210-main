using System;


public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool USAddressCheck()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
        // edit note: made a bool method that will check whether the address is inserted as an abbreviation or spelled out entirely
        // to match case sensitivities, I've also included a ToLower function that will check to see if it is either as well. //
    }

    public string GetAddressSummary()
    {
        return $"\n{_streetAddress}, {_city}, {_state}, {_country}";
    }

}