using System;


public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    // LLM explained the need on how to pass a class instance like this, basically using the class name, then declaring the instantiated instance, and making it known within the class. //
    public Customer(string customerName, Address address)
    {
        
        _customerName = customerName;
        _customerAddress = address;
    }

    public bool LivesInUSA()
    {
        return _customerAddress.USAddressCheck();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"Client Account: {_customerName}");
        Console.WriteLine($"Address:");
        Console.WriteLine(_customerAddress.GetAddressSummary());
        Console.WriteLine($"USA Address Check: {LivesInUSA()}");
    }

}