public class Product
{
    private double _productId;
    private string _name;
    private float _price;
    private int _quantity;

    public Product(string name, float price, int quantity, double productId)
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

    public float TotalProductCost()
    {
        float total = _price * _quantity;
        return total;
    }


}