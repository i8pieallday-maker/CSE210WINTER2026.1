class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetLabel()
    {
        string returnString = "";

        int x = 1;

        foreach (Product product in _products)
        {
            returnString += $"Product {x}: {product.PackingInfo()}\n";
            x += 1;
        }
        return returnString;
    }

    public string GetShippingLabel()
    {
        return _customer.ShippingInfo();
    }

}