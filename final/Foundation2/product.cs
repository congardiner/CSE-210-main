using System;


public class Product
{
    private string _productName;
    private string _productID;
    private decimal _pricePerUnit;
    private int _quantityProduct;

    public Product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = price;
        _quantityProduct = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;

    }

    public decimal GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetTotalQuantity()
    {
        return _quantityProduct;
    }

    public decimal GetTotalCost()
    {
        return _pricePerUnit * _quantityProduct;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product Name: {_productName}");
        Console.WriteLine($"Product ID: {_productID}");
        Console.WriteLine($"Price Per Unit: {_pricePerUnit}");
        Console.WriteLine($"Quantity: {_quantityProduct}");
        Console.WriteLine($"Order Cost: ${GetTotalCost()}");
    } 



}