using System;

public class Cycling : Activity
{
    private double _speed; // kph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        if (speed <= 0)
        {
            throw new ArgumentException("Speed must be greater than 0.");
        }

        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}