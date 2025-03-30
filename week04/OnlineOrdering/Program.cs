using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Address address = new Address("4556 S 4536 W", "Riverton", "Utah", "USA");
        Customer jeff = new Customer("Jeff", address);
        Order order1 = new Order(jeff);
        Product ductTape = new Product("Duct Tape", 2534, 2, 10.99);
        Product tapeMeasure = new Product("Tape measure", 2345, 1, 30.99);
        
        order1.AddProduct(ductTape);
        order1.AddProduct(tapeMeasure);

        Console.WriteLine(order1.PrintShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.PrintPackingLabel());
        Console.WriteLine(order1.TotalCost());

        Address address2 = new Address("lot 316 Bendor", "Polokwane", "Limpopo", "South Africa");
        Customer thato = new Customer("Thato", address2);
        Order order2 = new Order(thato);
        Product stick = new Product("Stick", 123, 2, 5.99);
        Product jetSki = new Product("Jet Ski", 234, 1, 3999.99);

        order2.AddProduct(stick);
        order2.AddProduct(jetSki);

        Console.WriteLine(order2.PrintShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.PrintPackingLabel());
        Console.WriteLine(order2.TotalCost());
    }
}