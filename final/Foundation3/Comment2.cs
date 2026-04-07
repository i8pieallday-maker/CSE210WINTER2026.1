using System.Collections.Generic;

public class Comment
{
    public string CommentName{get; set;}
    public string CommentText{get; set;}
    
    public Comment(string name, string text)
    {
        CommentName = name;
        CommentText = text;
    }
}
