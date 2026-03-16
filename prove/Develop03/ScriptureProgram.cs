using System;

class Program
{
    public static void Display(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("enter q to quit or hit return to hide words");
        scripture.DisplayScripture();
    }
    static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>();
        //scriptures.Add(new Scripture("Alma", 5, 1, 2, "and my father dwelt in a tent"));
        scriptures.Add(new Scripture("Helaman", 5, 12, 0, "And now my sons, I say unto you, Fear not. "));
        scriptures.Add(new Scripture("Alma", 7, 11, 12, "Took upon Him death."));
        scriptures.Add(new Scripture("Jeremiah", 33, 3, 0, "Call unto me, and I will answer thee, and show thee great and mighty things, which thou knowest not."));
        scriptures.Add(new Scripture("Matthew", 7, 7, 0, "Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you."));
        scriptures.Add(new Scripture("Philippians", 4, 13, 0, "I can do all things through Christ, which strengtheneth me."));
        scriptures.Add(new Scripture("Matthew", 6, 33, 0, "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you"));
        scriptures.Add(new Scripture("James", 4, 7, 0, "Submit yourselves therefore to God. Resist the devil, and he will flee from you."));
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];
        Display(scripture);

        bool done = false;
        while (!done)
        {
            if (scripture.HideWords())
            {
                done = true;
            }
            else
            {
                string response = Console.ReadLine();
                if (response == "q")
                {
                    done = true;    
                }  
            }
            Display(scripture);
        }
    }
}

/*
Reference:
- Book: string
- Chapter: int  
- Startverse: int
- Endverse: int

string _bookName:
_chatper int
_verse int[]
+scripturereference(string name, int cha[et, int verse])
^ w/end verse
showscripture reference() void
getscripture reference string

- getscripturereferencestring: stirng

Scripture
- reference 
- list (List(word) _word)

Word
- text: string
- flag (hidden)- bool that might hide word



Program


*/