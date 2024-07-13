using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("75 N 6th S Wilmington Cabin Dr", "Oxford", "", "United Kingdom");
        Address address2 = new Address("123456 TH Street", "SmallTown", "TX", "USA");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Lexington Concord the 3rd", address2);

        Product product1 = new Product("Samsung Galaxy S24 Ultra", "NonExynos", 1100, 1);
        Product product2 = new Product("Google Pixel 9 Pro XL", "G4", 1300, 1);
        Product product3 = new Product("Apple Iphone 15 Pro Max", "134USA", 1500, 1);
        Product product4 = new Product("Motorola Edge 2024", "567", 1000, 1);
        Product product5 = new Product("One Plus Open", "O890", 1600, 1);

        // edit note: tested cases of numerous products being added with subtotal(s). // 
        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 1);
        order1.AddProduct(product2, 2);
        order1.AddProduct(product3, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2, 4);
        order2.AddProduct(product4, 3);
        order2.AddProduct(product5, 1);

        Console.WriteLine("Order 1 Contents: ");
        Console.WriteLine(order1.GetOriginLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order1.TotalPrice():F2}");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Order 2 Contents: ");
        Console.WriteLine(order2.GetOriginLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order2.TotalPrice():F2}");
        Console.WriteLine();
        Console.WriteLine();
    }
}