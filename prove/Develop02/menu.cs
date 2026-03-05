
class Menu
{
    public string[] _menuStrings = {
        "Welcome to the internet",
        "you can Create Display save and load journal entries",
        "1. Create entry",
        "2. Display Journal",
        "3. Save Journal to file",
        "4. Read Jornal from file",
        "5. Quit"

    };

    public int ProcessMenu()
    {
        int userResponse = 0;

        do
        {
             Console.Clear();
        foreach(string line in _menuStrings)
        {
            Console.WriteLine(line);
        }
        userResponse = int.Parse(Console.ReadLine());
        }while(userResponse <1 || userResponse > 5);
       
        return userResponse;
    }
}