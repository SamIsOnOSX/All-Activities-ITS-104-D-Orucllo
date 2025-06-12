using System;

public struct Time
{
    private readonly int minutes;
    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public override String ToString()
    {
        return minutes.ToString();
    }
}

class Program
{
    static void Main()
    {
        Time time1 = new Time(10, 5);
        Time time2 = new Time(0, 45); 
        Time time3 = new Time(23, 30);

        
        Console.WriteLine("Time 1 (10:05 AM): " + time1);
        Console.WriteLine("Time 2 (12:45 AM): " + time2);
        Console.WriteLine("Time 3 (11:30 PM): " + time3);
    }
}
