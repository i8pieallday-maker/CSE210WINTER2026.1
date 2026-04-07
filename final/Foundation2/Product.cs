class Product
{
    private string _name;
    private int _productID;
    private int _pricePerUnit;
    private int _quantity;

    public TotalCost(int price, int quantity)
    {
        _pricePerUnit = price;
        _quantity = quantity;
    }
}