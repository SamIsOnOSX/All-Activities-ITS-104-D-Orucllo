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
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a time - Hours (0-23): ");
        int hh1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a time - Minutes (0-59): ");
        int mm1 = int.Parse(Console.ReadLine());

        Time inputTime = new Time(hh1, mm1);
        Console.WriteLine("\nYou entered: " + inputTime);

        Console.Write("\nEnter another time to add/subtract - Hours (0-23): ");
        int hh2 = int.Parse(Console.ReadLine());
        Console.Write("Enter another time - Minutes (0-59): ");
        int mm2 = int.Parse(Console.ReadLine());

        Time secondTime = new Time(hh2, mm2);

        Time addedTime = inputTime + secondTime;
        Time subtractedTime = inputTime - secondTime;

        Console.WriteLine("\nInput Time: " + inputTime);
        Console.WriteLine("Added Time: " + addedTime);
        Console.WriteLine("Subtracted Time: " + subtractedTime);
    }
}
