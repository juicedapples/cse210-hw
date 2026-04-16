using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        if (distance <= 0)
        {
            throw new ArgumentException("Distance must be greater than 0.");
        }

        _distance = distance;
    }
}