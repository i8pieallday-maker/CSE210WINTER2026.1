class Reception: Event
{
    private string _rsvp;

    public Reception(string title, string description, int date, int time, Address address, string rsvp) 
        : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override string GetEventType()
    {
        return "Reception";
    }
}