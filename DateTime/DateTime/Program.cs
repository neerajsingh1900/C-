using System;

public class Program
{
    public static void Main(string[] args)
    {

       DateTime d = DateTime.Now;
        DateTime curr;
        Console.WriteLine(d);
        string s = "2025-08-21 02:20:13.888 PM";
        curr = DateTime.Parse(s);
        Console.WriteLine(curr);

        Console.WriteLine("ALL PROPERTIES");

        Console.WriteLine($"DATE is:{curr.Date}");
        Console.WriteLine($"MONTH is:{curr.Month}");
        Console.WriteLine($"Year is:{curr.Year}");
        Console.WriteLine($"hour is:{curr.Hour}");
        Console.WriteLine($"minute is:{curr.Minute}");
        Console.WriteLine($"second is:{curr.Second}");
        Console.WriteLine($"Millisec is:{curr.Millisecond}");

        DayOfWeek dd = curr.DayOfWeek;
        Console.WriteLine($"DayOfWeek is:{dd}");

        int m = curr.DayOfYear;
        Console.WriteLine($"DayOfYear is:{m}");

        DateTime mmm = DateTime.Now;
        Console.WriteLine($"Current Time is:{mmm}");

        Object obj = DateTime.Now;

        Console.WriteLine(obj);





    }
}