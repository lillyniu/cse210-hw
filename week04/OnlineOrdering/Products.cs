public class Product
{
    private string _name;
    private decimal _price;
    private int _productId;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;        
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
    
    public string GetName() => _name;
    public int GetProductId() => _productId;
}