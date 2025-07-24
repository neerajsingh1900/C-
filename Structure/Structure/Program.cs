using System;

struct Car
{
    public int Id;  
    public string Name;

    public Car()
    {
        Id = 0;
        Name = "singh";
    }
    public void Show()
    {
        System.Console.WriteLine(Name);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car c = new Car(); 
        c.Show();
    }
}