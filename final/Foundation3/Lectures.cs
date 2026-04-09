class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, int date, int time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }
    
    // public virtual string Details()
    // {
        
    // }
    
}