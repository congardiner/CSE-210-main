using System;

public class Order
{
    private int _usaShippingCost = 5;
    private int _outsideShippingCost = 35;
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    

    private void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private void TotalPrice()
    {
        
    }

    public string GetPackingLabel()
    {
        
        return $"Shipping Label:\n {_customer.}";

    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{product.GetProductName}";

    }



}