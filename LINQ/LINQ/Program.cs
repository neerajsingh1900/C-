using System;
using System.Linq;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Manager {  get; set; }    
    public string Location {  get; set; }   
    public string Job {  get; set; }    

}
public class Program
{
    static void Print(IEnumerable<Employee> e)
    {
        Console.WriteLine("in:");
        foreach (Employee i in e)
        {
            Console.WriteLine(i.Id + " " + i.Name + " " + i.Location + " " + i.Manager);
        }
    }
    
    public static void Main(string[] args)
    {
        List<Employee> l = new List<Employee>()
        {
            new Employee(){Id=1,Name="Neeraj Singh" ,Manager ="Lokesh" ,Location = "Shimla"},
            new Employee(){Id=4,Name="Ankit Singh" ,Manager ="Sohan" ,Location = "Himachal"},
            new Employee(){Id=2,Name="Sumit Singh" ,Manager ="Rajesh" ,Location = "Himachal"},
            new Employee(){Id=3,Name="Amit Singh" ,Manager ="Keshri" ,Location = "Mumbai"}
        };


      IEnumerable<Employee> e =   l.Where(e=>e.Id>=2);

       // Print(e);

        // List<Employee> e = l.OrderBy(e => e.Id).ToList;
       
        e = l.OrderBy(e => e.Id);

        //Print(e);

        //e = l.OrderBy(e => e.Job).ThenBy(e=> e.Manager);

        //Print(e);

        //  e = l.OrderByDescending(e=> e.Id);

        // Print(e);

        e = l.OrderByDescending(e => e.Job).ThenBy(e => e.Id);

        //Print(e);


        Employee em = l.First(i => i.Location == "Himachal");
        //  Console.WriteLine(em.Id + " " + em.Name + " " + em.Manager);

        //  em = l.First(i => i.Location == "New York");
        //em = l.FirstOrDefault(i => i.Location == "New York");

        //Console.WriteLine(em?.Id);

        //em = l.Last(i => i.Location == "New York");
        //Console.WriteLine(em.Id);

        //em = l.LastOrDefault(i => i.Location == "New York");
        //Console.WriteLine(em?.Id);  

        // em = l.Where(i => i.Location == "New York").ElementAt(1);
        //   e = l.Where(i => i.Location == "New York");
        // Console.WriteLine(e.GetEnumerator());
        // Print(e);


        //em = l.Single(i=>i.Id ==1);  
        //Console.WriteLine(em.Manager);

        //em = l.Single(i => i.Id == 8);
        //Console.WriteLine(em.Manager);  

        //em = l.SingleOrDefault(i=> i.Id == 1);
        //Console.WriteLine(em.Manager);

        em = l.SingleOrDefault(i => i.Name == "Rahul");

        Console.WriteLine(em?.Manager);  

    }
}