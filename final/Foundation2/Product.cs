public class Product
{
    private double _productId;
    private string _name;
    private decimal _price;
    private int _quantity;

    public Product(string name, decimal price, int quantity, double productId)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _productId = productId;

    }

    public string GetName()
    {
        return _name;
    }

    public double GetProductId()
    {
        return _productId;
    }

    public decimal TotalProductCost()
    {
        decimal total = _price * _quantity;
        return total;
    }


}