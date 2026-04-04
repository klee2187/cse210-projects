public class Product
{
    
    private string _name;
    private double _productId;
    private int _quantity;
    private decimal _price;

    public Product(string name, double productId, int quantity, decimal price)
    {
        _productId = productId;
        _name = name;
        _quantity = quantity;
        _price = price;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public decimal TotalProductCost()
    {
        decimal total = _price * _quantity;
        return total;
    }
}