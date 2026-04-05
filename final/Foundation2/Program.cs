using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        //Make addresses
        List<Address> addresses = new List<Address>();
        addresses.Add(new Address("42 Wallaby Way","Sydney","NSW","Australia"));
        addresses.Add(new Address("123 Main Street","New York City","NY","United States"));

        //Make customers
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer("P Sherman",addresses[0]));
        customers.Add(new Customer("Joe Schmoe",addresses[1]));

        //Make orders
        List<Order> orders = new List<Order>();
        orders.Add(new Order(customers[0]));
        orders.Add(new Order(customers[1]));

        //Add items to orders
        orders[0].AddProduct("Finding Nemo Lunchbox",27.99,1);
        orders[0].AddProduct("Snorkel Goggles",39.99,2);
        orders[1].AddProduct("Suzy-Qable for Chromebook",7.99,1);
        orders[1].AddProduct("Tighty Whities 6pk",15.99,400);

        //Print stuff
        Console.WriteLine("Amazon Fulfillment\nToday's orders:");
        foreach(Order order in orders)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetTotalCost());
        }
    }
}