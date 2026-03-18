class Program2
{

    public static void ProcessPerson(Person person)
    {
        if (person is Police police)
        {
            Console.WriteLine(police.GetPoliceInformation());
        }
        else if (person is Doctor doctor)
        {
            Console.WriteLine(doctor.GetDoctorInformation());
        }
        else
        {
            Console.WriteLine(person.GetPersonInformation());
        }
    }
    public static void Main(string[] args)
    {
        Person person = new Person("Bob", "Henry", 55, 196);
        Console.WriteLine(person.GetPersonInformation());

        Police myPolice = new Police("Gun", "Lance", "Arnold", 98, 20);
        Console.WriteLine(myPolice.GetPoliceInformation());

        Doctor myDoctor = new Doctor("kinfe", "bobby", "billy", 75, 189);
        Console.WriteLine(myDoctor.GetDoctorInformation());

        
        // myPolice.SetWeight(myPolice.GetWeight() + 5);
        // myPolice.SetAge(myPolice.GetAge()+1);
        Console.WriteLine(myPolice.GetPoliceInformation());

        List<Person> myPeople = new List<Person>();
        myPeople.Add(person);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person tempPerson in myPeople)
        {
            //Console.WriteLine(tempPerson.GetPersonInformation());
            ProcessPerson(tempPerson);
        }

    }
}
