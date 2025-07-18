using System;

public class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee(1,"Neeraj");
        Employee e1 = new Employee(2, "Sumit");
        Employee e2 = new Employee(3, "Rohit");
        Employee e3 = new Employee(4, "Rohan");

       System.Console.WriteLine(e.getId());
        System.Console.WriteLine(e1.getId());
        System.Console.WriteLine(e2.getId());
        System.Console.WriteLine(e3.getId()); 
        

        System.Console.WriteLine(e.getName());
        System.Console.WriteLine(e1.getName());
        System.Console.WriteLine(e2.getName()); 
        System.Console.WriteLine(e3.getName()); 
        

    }
}