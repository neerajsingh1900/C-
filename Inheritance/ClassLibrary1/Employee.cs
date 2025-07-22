using System;


public class Employee
{

    public Employee(int id, string name, string location, string region)
    {
        Id = id;
        Name = name;
        Location = location;
        Region = region;
    }


    public int Show()
    {
        System.Console.WriteLine("This is showing of parent");
        return 1;

    }

    public virtual bool Got()
    {
        System.Console.WriteLine("parent");
        return false;
    }

    public int Id { get; set; } = 88888;
    public string Name { get; set; }
    public string Location { get; set; }

    public string Region { get; set; }

}