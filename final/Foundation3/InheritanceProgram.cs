using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("335 n 100 e","Farmington", "Utah", "Usa");
        Lecture lecture = new Lecture("sticky notes", "Stick to it: why do they stick?", 09302004, 1311, address1, "collective hive mind of burnt out college students", 1);
        Outdoor outdoor = new Outdoor("Bar Mitzvah", "Come join us for the adelaid parade", 04092026, 1412, address1, "Hurricane");
        Reception reception = new Reception("");
        Console.WriteLine(myEvent.Details());
        Console.WriteLine(myEvent.GetDescription());
        Console.WriteLine(lecture.FullDetails());
    }
}