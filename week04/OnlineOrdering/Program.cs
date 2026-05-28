using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");

        Customer customer1 = new Customer("Momoh Smith", address1);

        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 50, 1));

        Address address2 = new Address("45 Broad Road", "Lagos", "Lagos", "Nigeria");

        Customer customer2 = new Customer("Paul Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P200", 600, 1));
        order2.AddProduct(new Product("Headphones", "P201", 80, 2));

         Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n********************\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}