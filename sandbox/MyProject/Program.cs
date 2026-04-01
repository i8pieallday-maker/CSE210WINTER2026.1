class Program
{
    public static void Main(string[] args)
    {
        string? name2 = null;
        int? length = name2?.Length;

        Console.WriteLine(length);
        Console.WriteLine(name2?.Length);

         name2 = "bubby";
         length = name2?.Length;
        Console.WriteLine(length);

        name2 ??= "Jeannie";
        Console.WriteLine(name2);
    }
}