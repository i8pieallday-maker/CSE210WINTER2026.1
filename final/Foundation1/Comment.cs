class Comment
{
    private string CommentName;
    private string CommentText;
    
    public Comment(string name, string text)
    {
        CommentName = name;
        CommentText = text;
    }
    public string GetComment()
    {
        return CommentText;
    }
    public string GetName()
    {
        return CommentName;
    }
}
