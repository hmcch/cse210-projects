using System;

class Program
{
    static void Main(string[] args)
    {
        //CUSTOMER USA CASE
        //Creating address object
        Address a1 = new Address("215 W Main St", "Rexburg", "ID", "USA");
        //Passing client name and address
        Customer c1 = new Customer("Alexander Green", a1);

        //Creating the order for customer
        Order order1 = new Order(c1);
        //Adding products into the order list
        //Order should be Name, ID/SKU, Price, Amount
        order1.AddProduct(new Product("Laptop", "LP100", 1200, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 30, 2));

        //Customer International Case
        //Address outside USA to verify shipping cost changes
        Address a2 = new Address("Avenida Vasco de Quiroga", "Ciudad de Mexico", "Santa Fe", "Mexico");
        Customer c2 = new Customer("Ramiro Montes", a2);

        //Creating order for customer
        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Phone", "PH500", 500, 1));
        order2.AddProduct(new Product("Charger", "CH100", 10, 3));

        //Printing order shipped to USA
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order1.GetTotalPrice()}\n");

        //Printing order shipped outside USA
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order2.GetTotalPrice()}\n");
    }
}