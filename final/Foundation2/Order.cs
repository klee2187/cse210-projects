using System.Numerics;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _shipping;

    public Order(Customer customer, float shipping)
    {
        _customer = customer;
        _shipping = shipping;
    }

    public float GetShippingCost()
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

    public float GetTotalCost()
    {
        float total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalProductCost();
        }

        total += GetShippingCost();

        return total;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"{_customer.GetName}");

        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} - {product.GetProductId()}");
        }
    }
}