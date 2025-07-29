using System;


public class Employee
{
    public Nullable<int> id;
    public char? no;

}

public class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee();
        e.id = 1;
        e.no = 'S';
        Employee e1 = new Employee();
        e1.id = null;
        e1.no =  null;
        Employee e2 =null;

         
        Console.WriteLine(e1.id??2);
        Console.WriteLine(e.no??'a');
        
        Console.WriteLine(e?.id);
        Console.WriteLine(e2?.id);
        Console.ReadKey();
    }
}