using System;


public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    private Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public GetUSAAddressCheck()
    {


    }

    public ReturnAddressSummary()
    {
        Console.WriteLine("Address Summary: ");
        Console.WriteLine($"\n{_streetAddress} | {_city} | {_state} | {_country}");
    }










}