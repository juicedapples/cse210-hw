using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Creating Comment instances
            var comm1 = new Comment("Claire", "Definitely subbing");
            var comm2 = new Comment("Allen", "Thank you for the video!");
            var comm3 = new Comment("Mia", "Awesome! Love your content. :)");
            var comm4 = new Comment("Lola", "Hmmm I need a follow-up video because I got lost.");

            // Creating Video instances
            var vid1 = new Video("How to Draw a Cat", "CatLovers", 300);
            var vid2 = new Video("How to Draw a Penguin", "Drawing with Clark", 400);
            var vid3 = new Video("What is the best Drawing tools?", "Art and Beyond", 450);

            vid1.AddVideoComment(comm1);
            vid1.AddVideoComment(comm2);
            vid1.AddVideoComment(comm3);

            vid2.AddVideoComment(comm4);
            vid2.AddVideoComment(comm1);

            vid3.AddVideoComment(comm2);
            vid3.AddVideoComment(comm4);

            List<Video> videoList = new List<Video> { vid1, vid2, vid3 };

            foreach (var video in videoList)
            {
                video.DisplayVideoDetails();
            }
        }
        catch (Exception ex)
        {
            // creative add on to handle error codes
            ErrorHandler.HandleException(ex);
        }
    }
}