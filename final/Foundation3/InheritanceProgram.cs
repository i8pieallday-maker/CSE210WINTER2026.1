using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("335 n 100 e","Farmington", "Utah", "Usa");
        Event myEvent = new Event("helo", "adf", 234234, 123213, address1);
        Lecture lecture = new Lecture("sticky notes", "Stick to it: why do they stick?", 09302004, 1311, address1, "collective hive mind of burnt out college students", 1);
        Console.WriteLine(myEvent.Details());
        Console.WriteLine(myEvent.GetDescription());
        Console.WriteLine(lecture.GetDescription());
    }
}