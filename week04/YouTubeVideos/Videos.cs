using System;
using System.Collections.Generic;

public class Video
{

    private string _videoTitle;
    private string _creatorName;
    private int _duration;
    private List<Comment> _videoComments;


    public Video(string videoTitle, string creatorName, int duration)
    {
        _videoTitle = videoTitle;
        _creatorName = creatorName;
        _duration = duration;
        _videoComments = new List<Comment>();
    }

    public string GetVideoTitle()
    {
        return _videoTitle;
    }

    public void SetVideoTitle(string videoTitle)
    {
        _videoTitle = videoTitle;
    }

    public string GetCreatorName()
    {
        return _creatorName;
    }

    public void SetCreatorName(string creatorName)
    {
        _creatorName = creatorName;
    }

    public int GetVideoLength()
    {
        return _duration;
    }

    public void SetVideoLength(int duration)
    {
        _duration = duration;
    }

    public void AddVideoComment(Comment comment)
    {
        _videoComments.Add(comment);
    }

    public int GetTotalComments()
    {
        return _videoComments.Count;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {_videoTitle}");
        Console.WriteLine($"Creator: {_creatorName}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"Total Comments: {GetTotalComments()}");
        Console.WriteLine("Comments:");

        for (int i = 0; i < _videoComments.Count; i++)
        {
            Console.WriteLine($" - {_videoComments[i]}");
        }
        Console.WriteLine(new string('-', 40));
    }
}