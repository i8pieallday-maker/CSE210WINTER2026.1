class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(string book, int chapter, int Startverse, int Endverse, string text)
    {
        _reference = new Reference(book, chapter, Startverse, Endverse);
        _words = new List<Word>();
        CreateWordList(text);
    }

    private void CreateWordList(string text)
    {
        string[] tempWords = text.Split();
        foreach(string W in tempWords)
        {
            Word tempW = new Word(W);
            _words.Add(tempW);
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());
        foreach(Word W in _words)
        {
            Console.Write($"{W.GetWordString()} ");
        }
        Console.WriteLine();
    }
    public void HideWords()
    {
        int HiddenCount = 0;
        int WordsToHide = 3;
        foreach (Word w in _words)
        {
            if (w.IsHidden())
            {
                HiddenCount++;
            }
        }
        Random myRandom = new Random();
        if (_words.Count - HiddenCount < 3)
        {
            WordsToHide = _words.Count - HiddenCount;
        } 
        for (int i = 0; i < WordsToHide;)
        {
            int index = myRandom.Next(0,_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].HideWord();
                i++;
            }
        }
    }
}
