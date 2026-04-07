using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Video video = new Video("How to do things", "a bee", 90);
        Video video2 = new Video("How to fix ");

//need to make a bunch more comments and stuff
        video.AddComment(new Comment("Tiffany","Incredible"));
        video.AddComment(new Comment("alexbees", "beeutiful"));
        video.AddComment(new Comment("creampuff", "WOAH"));

        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length: {video.Length}");
        Console.WriteLine($"Comment: {video.GetCommentCount()}");

        foreach (Comment comment in video.GetComments())
        {
            Console.WriteLine($"{comment.GetName()}: {comment.GetComment()}");
        }
    }
}

