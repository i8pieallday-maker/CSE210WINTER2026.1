class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    private int _guests;

    public Lecture(string title, string description, int date, int time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _guests = Convert.ToInt32(_capacity * 0.05);
    }

    public override string GetEventType()
    {
        return "Lecture";
    }

    public int Guests()
    {
        return _guests;
    }

    public override string Relevant()
    {
        return $"Speaker will be {_speaker}. Please limit those accompanying to {_guests}, as house capacity is {_capacity}.";
    }
    
    // public virtual string Details()
    // {
        
    // }
    
}