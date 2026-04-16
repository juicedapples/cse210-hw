using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        if (laps <= 0)
        {
            throw new ArgumentException("Laps must be greater than 0.");
        }

        _laps = laps;
    }

}