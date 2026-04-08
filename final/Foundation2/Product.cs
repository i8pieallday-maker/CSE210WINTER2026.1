class Product
{
    private string _name;
    private int _productID;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public double GetPrice()
    {
        return _pricePerUnit * _quantity;
    }

    public string PackingInfo()
    {
        return $"{_name} (ID: {_productID})";
    }

}