class Address()
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public isInUSA(string country)
    {
        _country = country;
        if (country = "USA")
        {
            return true;
        }
    }
    public getFullAddress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        Console.WriteLine($"Address: {street},{city},{state},{country}");
    }
}