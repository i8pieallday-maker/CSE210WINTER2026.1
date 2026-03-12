using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Bob");
        Console.WriteLine(myWord.GetWordString());
        myWord.HideWord();
        Console.WriteLine(myWord.GetWordString());

        Word myWord2 = new Word("Moroni");
        Console.WriteLine(myWord2.GetWordString());
        myWord2.HideWord();
        Console.WriteLine(myWord2.GetWordString());
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