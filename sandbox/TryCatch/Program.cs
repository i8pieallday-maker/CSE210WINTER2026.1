class Program
{
    public static int GetAge()
    {
        int age = 0;
        bool done = false;
        while (!done)
        {
            try
            {
                Console.Write("Please Write ur age: ");
            age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Please enter valid age");
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("valid age plz");
            }
            
        }
        
        return age;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Howdy");
        Console.WriteLine($"Your age is {GetAge()}");
    }
}