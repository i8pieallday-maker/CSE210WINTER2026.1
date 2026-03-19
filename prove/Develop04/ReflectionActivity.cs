
class ReflectionActivity : BaseActivity
{

    private string[] prompts =
    {
        "hello this is a prompt be inspired"
    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }

    public void RunActivity()
    {
        Console.WriteLine();
        Greeting();
        //get number of seconds
        //get ready -> run countdown
        //while seconds exist etc. 
        //let em think
        //display ending
    } 
}
