using System;
using System.Security.Cryptography;

public class Order
{
    private int _usaShippingCost = 5;
    private int _outsideShippingCost = 35;
    private List<Product> products = new List<Product>();



    private void AddOrder()
    {

    }

    private void TotalPrice()
    {
        
        Console.WriteLine($"Total Price of the Order: {_orderTotal}");
    }

    private void GetPackingLabel()
    {
        
        //Console.WriteLine($"")

    }

    private void GetShippingLabel()
    {


    }



}