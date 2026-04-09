class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, int date, int time, Address address, string weather) 
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }
}