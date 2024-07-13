using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("6528 Manassas Drive", "Pewee Valley", "Kentucky", "USA"); 
        Address address2 = new Address("3616 Jill Street", "Idaho Falls", "Idaho", "USA"); 
        Address address3 = new Address("348 3 ST W", "Cardston", "AB T0K 0K0", "Canada"); 

        Customer customer1 = new Customer("Derek Peterson", address1);
        Customer customer2 = new Customer("Britney Croney", address2);
        Customer customer3 = new Customer("Hyrum Pope", address3);

        Product product1 = new Product("Cheez-IT", "1", 3.99, 1); 
        Product product2 = new Product("Pepsi", "2", 2.99, 1); 
        Product product3 = new Product("Watermelon", "3", 5.99, 1); 
        Product product4 = new Product("Chewy Spree", "4", 4.99, 1); 

        Order order1 = new Order(customer1);
        order1.AddProduct(product4);
        order1.AddProduct(product4); 
        order1.AddProduct(product2); 
        order1.AddProduct(product3); 

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CostOfOrder():F2}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CostOfOrder():F2}"); 
        Console.WriteLine(); 
        
        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CostOfOrder():F2}"); 
        Console.WriteLine();


    }
}