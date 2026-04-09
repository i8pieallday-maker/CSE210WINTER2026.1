using System;

class Program2
{
    static void Main(string[] args)
    {
        //usa
        Address address1 = new Address("335 n 100 e","Farmington", "Utah", "Usa");
        Customer customer1 = new Customer("Barthalemew", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("poison", 12903, 300, 120));
        order1.AddProduct(new Product("powered garden wagon", 12345, 15, 1));
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetLabel());
        Console.WriteLine(order1.GetTotalCost());

        //international
        Address address2 = new Address("555 Cherry lane", "Keystone Heights", "Florida", "Bolivia");
        Customer customer2 = new Customer("Allie", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("my eyes hurt", 00000, 42, 67));
        order2.AddProduct(new Product("Water or something", 20420, 96, 100));
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetLabel());
        Console.WriteLine(order2.GetTotalCost());
    }   
}