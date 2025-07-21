using System;


public class Done
{
    private int i;
    private string m;
    private static double on ;
    private int salary;
    private int roll;


    public Done(int salary)
    {
        this.salary = salary;
    }
    public int Inte
    {
        set
        {
            i = value;
        }
        get
        {
            return i;
        }
    }
    public string Stringg
    {
        set
        {
            m = value;
        }
        get
        {
            return m;
        }
    }
    public static double Onnn
    {
        set
        {
            on = value;
        }
        get
        {
            return on;
        }
    }

    public int Sal
    {
        get
        {
            return salary;
        }

    }
    public int Rool
    {
        set
        {
            roll = value;
        }
    }

    public int Auto
    {
        set; get;
    }


}
public class Program
{
    public static void Main(string[] args)
    {
        Done d = new Done(45);
        d.Inte = 90;
        d.Stringg = "Hell";
        Console.WriteLine(d.Stringg);
        Console.WriteLine(d.Inte);
        d.Inte = 88;
        d.Stringg = "do";
        Console.WriteLine(d.Stringg);
        Done.Onnn = 7.89;
        Console.WriteLine(Done.Onnn);
        Done j = new Done(89);
        Console.WriteLine(j.Sal);
        j.Rool = 5796;


        j.Auto = 66;
        Console.WriteLine(j.Auto);

    }
}