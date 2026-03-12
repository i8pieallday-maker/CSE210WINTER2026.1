using System;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Bob");
        // Console.WriteLine(myWord.GetWordString());
        // myWord.HideWord();
        // Console.WriteLine(myWord.GetWordString());

        // Word myWord2 = new Word("Moroni");
        // Console.WriteLine(myWord2.GetWordString());
        // myWord2.HideWord();
        // Console.WriteLine(myWord2.GetWordString());

        // Reference scripture = new Reference("Alma", 5, 1, 2);
        // Console.WriteLine(scripture.GetReference());
        // Reference scripture2 = new Reference("Alma", 5, 1, 0);
        // Console.WriteLine(scripture2.GetReference());

        Scripture scripture3 = new Scripture("Alma", 5, 1, 2, "i want to be the very best that no one ever was pokemon gotta catch em all");
        // scripture3.DisplayScripture();
        // scripture3.HideWords();
        // scripture3.DisplayScripture();
        
        Console.Clear();
        Console.WriteLine("enter q to quit or hit return to hide words");
        scripture3.DisplayScripture();
        bool done = false;
        while (!done)
        {
            if (scripture3.HideWords())
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
            Console.Clear();
            Console.WriteLine("enter q to quit or hit return to hide words");
            scripture3.DisplayScripture();
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