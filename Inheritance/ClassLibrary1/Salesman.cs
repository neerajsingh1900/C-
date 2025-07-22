using System;

public class Salesman : Employee
{
  public Salesman(int id, string name, string location, string region) : base(id,name,location,region)
    {

    }
    public void GetSalesOfCurrentMonth()
    {
        System.Console.WriteLine("July :89");
    }
    
}