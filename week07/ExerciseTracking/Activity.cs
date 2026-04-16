using System;
//base class
public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        if (minutes <= 0)
        {
            throw new ArgumentException("Minutes must be greater than 0.");
        }

        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

}