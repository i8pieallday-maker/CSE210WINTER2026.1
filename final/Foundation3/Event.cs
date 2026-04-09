class Event
{
    private string _title;
    private string _description;
    private int _date;
    private int _time;
    private Address _address;

    public Event(string title, string description, int date, int time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public virtual string Details()
    {
        return $"{_title}: {_description} will be held on {_date} at {_time}.\n{_address.GetFullAddress()}.";
    }

    public virtual string FullDetails()
    {
        return $"The {GetEventType()} {_title}: {_description} will be held on {_date} at {_time}.\n{_address.GetFullAddress()}. Relevant information: {Relevant()}";
    }
    public virtual string GetEventType()
    {
        return "Event";
    }
    public virtual string Relevant()
    {
        return "Relevant";
    }
    public virtual string GetDescription()
    {
        return $"{GetEventType()}: {_title} on {_date}";
    }
}