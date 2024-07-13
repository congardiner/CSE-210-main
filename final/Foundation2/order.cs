using System;

public class Order
{   // edit note: called my private instances as constructors instead of making getters and setters to make my code cleaner //
    private const int UsaShippingCost = 5;
    private const int OutsideShippingCost = 35;
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    

    public void AddProduct(Product product, int quantity)
    {
        Product orderProduct = new Product(product.GetProductName(), product.GetProductID(), product.GetPricePerUnit(), quantity);
        _products.Add(orderProduct);
    }

    public decimal TotalPrice()
    {   
        decimal productTotal = _products.Sum(p => p.GetTotalCost());
        int shippingCost = _customer.LivesInUSA() ? UsaShippingCost : OutsideShippingCost;
        return productTotal + shippingCost;
        
    }

    public string GetOriginLabel()
    {
        return $"Origin Label: 123 Quarter West, Junction City, Colorado, United States";
    }

    public string GetPackingLabel()
    {
        
        return $"Packing Label:\n" + string.Join("\n", _products.Select(p => $"{p.GetProductName()} (ID: {p.GetProductID()})"));

    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()}{_customer.GetAddress().GetAddressSummary()}";

    }



}