using System;
using System.Linq;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Location { get; set; }
}

public class Employee
{
    public int Id { get; set; } 
    public string Name { get; set; }    
    public string Location {  get; set; }   

}
public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> l = new List<Employee>()
        {
            new Employee(){Id=1,Name = "Neeraj",Location ="Delhi"},
            new Employee(){Id=2,Name = "Sohan",Location ="Himachal"},
            new Employee(){Id=3,Name = "Ankit",Location ="Haryana"},
            new Employee(){Id=4,Name = "Sumit",Location ="Uttrakhand"},


        };
        IEnumerable<Person> e = l.Select(emp => new Person() {Id = emp.Id, Location=emp.Location,Name = emp.Name });

        foreach(Person  pi in e)
        {
            Console.WriteLine(pi.Name + " "+ pi.Location);    
        }

   List<Person> p=     l.Select(emp => new Person() { Id = emp.Id, Location = emp.Location, Name = emp.Name }).ToList();
        p.Add(new Person() { Id = 5, Location = "Mumbai", Name = "Gopal" });

        foreach(Person i in p)
        {
            Console.WriteLine(i.Name + " "+ i.Location);    
        }

        int a = l.Count();
        Console.WriteLine(a);

        double b  = l.Average(i => i.Id);
        Console.WriteLine(b);

        int c = l.Max(i => i.Id);
        Console.WriteLine(c);

        int k = l.Min(i => i.Id);
        Console.WriteLine(k);


        // query syntax
        var kk = from m in l
                 where m.Id > 1
                 orderby m.Location, m.Name
                 select new { m.Name, m.Id };

       foreach(var  m in kk)
        {
            Console.WriteLine(m);
        }

    }
}