using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Order Processing System ---");
        Console.WriteLine();

        Console.WriteLine("--- Order 1 Details ---");

        Address address1 = new Address("123 Maple Street", "Anytown", "CA", "USA");

        Customer customer1 = new Customer("Alice Wonderland", address1);
        Order order1 = new Order(customer1);

        Product product1A = new Product("Laptop Pro", "LP1001", 1200.50m, 1);
        Product product1B = new Product("Wireless Mouse", "WM205", 25.99m, 2);
        Product product1C = new Product("Keyboard", "KB300", 75.00m, 1);

        // Add products to order 1
        order1.AddProduct(product1A);
        order1.AddProduct(product1B);
        order1.AddProduct(product1C);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateTotalCost()}"); 
        Console.WriteLine("=========================================");
        Console.WriteLine();


        Console.WriteLine("--- Order 2 Details ---");


        Address address2 = new Address("456 Oak Avenue", "Otherville", "ON", "Canada");

        Customer customer2 = new Customer("Bob The Builder", address2);
        Order order2 = new Order(customer2);

        Product product2A = new Product("Smartphone X", "SPX900", 799.99m, 1);
        Product product2B = new Product("Phone Case", "PCX901", 19.50m, 1);

        order2.AddProduct(product2A);
        order2.AddProduct(product2B);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateTotalCost()}");
        Console.WriteLine("=========================================");
        Console.WriteLine();


        Console.WriteLine("--- Order 3 Details ---");
        Address address3 = new Address("789 Pine Lane", "Springfield", "IL", "USA");
        Customer customer3 = new Customer("Charles Xavier", address3);
        Order order3 = new Order(customer3);

        Product product3A = new Product("Advanced Gadget", "AG555", 199.95m, 1);
        Product product3B = new Product("Gadget Charger", "GC111", 29.50m, 2);

        order3.AddProduct(product3A);
        order3.AddProduct(product3B);

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 3 Total Cost: ${order3.CalculateTotalCost()}");
        Console.WriteLine("=========================================");


        Console.WriteLine("\nProgram finished. Press any key to exit.");
        Console.ReadKey();
    }
}