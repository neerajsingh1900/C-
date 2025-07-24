using System;

public class Program
{
    public static void Main(string[] args)
    {
        System.Object o = new Student() { Id = 1, Name = "Neeraj" };

        //only this method takes the parameter 
        Console.WriteLine(o.Equals(new Student() { Id = 1, Name = "Neeraj" }));


        Console.WriteLine(o.ToString());
        Console.WriteLine(o.GetHashCode());

        Console.WriteLine(o.GetType());


    }
}