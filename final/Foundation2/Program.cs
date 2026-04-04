using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("2568 Happy Street", "Aurora", "CO", 80017, "USA");

        Customer customer1 = new Customer("Sally Smith", address1);

        Product order1Product1 = new Product("Basketball", 00158794, 2, 19.99m);
        Product order1Product2 = new Product("Basketball Shorts", 00548792, 5, 12.00m);
        Product order1Product3 = new Product("Basketball Shoes", 00487596, 1, 75.00m);

        Address address2 = new Address("445 Frontier Land Street", "Mt Eden", "Auckland", 1010, "New Zealand");

        Customer customer2 = new Customer("Chet Stevens", address2);

        Product order2Product1 = new Product("Fishing Pole", 00645712, 1, 48.25m);
        Product order2Product2 = new Product("Tacklebox with lures", 00115422, 1, 35.98m);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        order1.AddProduct(order1Product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);

        order1.DisplayShippingLabel();
        order1.DisplayPackingLabel();
        order1.GetTotalCost();

        order2.DisplayShippingLabel();
        order2.DisplayPackingLabel();
        order2.GetTotalCost();
    }
}
    