using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var comment1 = new Comment("comment here");

        var video1 = new Video();
        video1.Comments.Add(comment1);

        var videos = new List<Video> { video1 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}