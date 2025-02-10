using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Product product1 = new Product("Dress", 296, 95, 3);
        Product product2 = new Product("Shoes", 125, 150, 2);
        Address address1 = new Address("Wood Cir", "Midvale", "UT", "USA");
        Customer customer1 = new Customer("Mele Latu", address1);

        List<Product> products1 = new List<Product>{product1,product2};
        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine(order1.GetShipLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():0.00}\n");

        Product product3 = new Product("Purse", 310, 725, 3);
        Product product4 = new Product("Jewelry", 382, 3500, 5);
        Address address2 = new Address("Koloa", "Ha'alaufuli", "Vava'u", "TO");
        Customer customer2 = new Customer("Tevita Tuakalau", address2);

        List<Product> products2 = new List<Product>{product3,product4};
        Order order2 = new Order(products2, customer2);

        Console.WriteLine(order2.GetPackLabel());
        Console.WriteLine(order2.GetShipLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():0.00}"); 
    }
}