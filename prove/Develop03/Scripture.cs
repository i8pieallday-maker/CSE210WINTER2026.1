class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(string book, int chapter, int Startverse, int Endverse, string text)
    {
        _reference = new Reference(book, chapter, Startverse, Endverse);
        _words = new List<Word>();
    }
}