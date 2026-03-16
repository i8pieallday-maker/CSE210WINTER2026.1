class Reference
{
    private string _book;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public Reference(string book, int chapter, int Startverse, int Endverse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Startverse;
        _endVerse = Endverse;
    }
    // public string GetBook()
    // {
    //     return _book;
    // }
    // public int GetChapter()
    // {
    //     return _chapter;
    // }
    // public int GetStartVerse()
    // {
    //     return _startVerse;
    // }
    // public int GetEndVerse()
    // {
    //     return _endVerse;
    // }
    public string GetReference()
    {
        if(_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}