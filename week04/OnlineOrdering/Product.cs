public class Product
{
    private string _productName;
    private int _productID;
    private int _quantity;
    private double _price;

    public Product(string productName, int productID, int quanity, double price)
    {
        _productName = productName;
        _productID = productID;
        _quantity = quanity;
        _price = price;
    }

    public string PackingLabel()
    {
        return $"{_productName}, ID: {_productID}";
    }
    public double TotalCost()
    {
        return _price * _quantity;
    }
}