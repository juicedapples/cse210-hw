using System;

public class Comment
{
    private string _userName;
    private string _message;

    public Comment(string userName, string message)
    {
        _userName = userName;
        _message = message;
    }

    public string GetUserName()
    {
        return _userName;
    }

    public void SetUserName(string userName)
    {
        _userName = userName;
    }

    public string GetMessage()
    {
        return _message;
    }

    public void SetMessage(string message)
    {
        _message = message;
    }

    public override string ToString()
    {
        return $"{_userName}: {_message}";
    }
}