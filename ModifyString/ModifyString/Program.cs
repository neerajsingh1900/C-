using System;


public class Program
{
    public static void Main(string[] args)
    {
        string name = "Neeraj";

        string k = name.Insert(6, " Singh");
        Console.WriteLine(k);

        string hh = k.Remove(6, 6);
        Console.WriteLine(hh);  
    }
}