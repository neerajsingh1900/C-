using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Employee
{
    private string name;
    private int id;

   public  Employee(int id,string name)
    {
        this.id = id;
        this.name = name;
    }

    public int getId()
    {
        return id;
    }
    public string getName()
    {
        return name;
    }
}