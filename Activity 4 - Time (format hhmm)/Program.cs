using System;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public int Hour
    {
        get { return minutes / 60; }
    }

    public int Minute
    {
        get { return minutes % 60; }
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
        
        Console.Write("Enter hour (0-23): ");
        int hh = int.Parse(Console.ReadLine());

        Console.Write("Enter minutes (0-59): ");
        int mm = int.Parse(Console.ReadLine());
        
        Time userTime = new Time(hh, mm);

        Console.WriteLine("You entered: " + userTime);
    }
}
