using System;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public Time(int totalMinutes)
    {
        this.minutes = totalMinutes;
    }

    public int Hour
    {
        get { return minutes / 60; }
    }

    public int Minute
    {
        get { return minutes % 60; }
    }

    public static Time operator +(Time t1, Time t2)
    {
        return new Time(t1.minutes + t2.minutes);
    }

    public static Time operator -(Time t1, Time t2)
    {
        return new Time(Math.Max(0, t1.minutes - t2.minutes));
    }

    public override string ToString()
    {
        return string.Format("{0:D2}:{1:D2}", Hour, Minute);
    }

 
    public static implicit operator Time(int totalMinutes)
    {
        return new Time(totalMinutes);
    }

   
    public static explicit operator int(Time t)
    {
        return t.minutes;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter minutes since midnight: ");
        int userMinutes = int.Parse(Console.ReadLine());

        Time userTime = userMinutes; 
        Console.WriteLine("Converted Time: " + userTime);

        int extractedMinutes = (int)userTime;
        Console.WriteLine("Extracted Minutes: " + extractedMinutes);
    }
}
