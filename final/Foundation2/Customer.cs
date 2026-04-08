class Customer
{
    private string _name;
    private int _address;

    public bool livesInUSA()
    {
        return _address.isInUSA();
    }
}