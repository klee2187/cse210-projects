using System.Numerics;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _shipping;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();    }

    public int GetShippingCost()
    {
        if (_customer.LiveInUSA() == true)
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }

        return _shipping;
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalProductCost();
        }

        total += GetShippingCost();

        Console.WriteLine($"Total cost: ${total}");

        return total;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"\n{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress().DisplayAddress()}\n");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");

        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetQuantity()} {product.GetName()} - {product.GetProductId()}");
        }
    }
}