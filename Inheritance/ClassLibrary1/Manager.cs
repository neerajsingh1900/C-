using System;

public class Manager:Employee
{
    private int manager_dep;
    private string manager_loc;
    public Manager(int dep , string loc, int id, string name, string location, string region):base(id,name,location,region)
    {
        manager_dep = dep;
        manager_loc = loc;  
    }

    //METHOD HIDING
    public new int Show()

    {
        System.Console.WriteLine("This is showing of Child");
        return 2;
    }

    public  override bool Got()

    {
       // base.Got();
        System.Console.WriteLine("child");
        return true;
    }

    public int Manager_dep
    {
          
        get { return manager_dep; } 
    }

    public string Manager_loc
    {
         
        get { return manager_loc; }
    }
    public void gettotalsalesofyear()
    {
        System.Console.WriteLine("897");
    }
}

public sealed class Chilld : Manager
{
    public Chilld(int dep, string loc, int id, string name, string location, string region) : base(dep, loc, id, name, location, region)
    {
    }

    public override bool Got()
    {
        System.Console.WriteLine("AGAIN OVERRIDE");
        return true;
    }
}