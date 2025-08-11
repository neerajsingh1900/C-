using System;


public class Customer:IEquatable<Customer>
{
    public int Id { get; set; } 
    public string Name { get; set; }    

    public bool Equals(Customer c)
    {
        return this.Id==c.Id && this.Name==c.Name;
    }

    //public  int CompareTo(Object c)
    //{
    //    return this.Id-((Customer)c).Id;
    //}

}

public class Customadd: IComparer<Customer>
{
    public int Compare(Customer x, Customer y)
    {
        return x.Name.CompareTo(y.Name);    
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        List<Customer> l = new List<Customer>();

        l.Add(new Customer() { Id = 1, Name = "Neeraj Singh" });
        l.Add(new Customer() {Id = 5, Name="Amrish" })  ;
        l.Add(new Customer() { Id = 8, Name = "Sourav" });
        l.Add(new Customer() { Id = 4, Name = "Rohan" });

        Customer cc = new Customer() { Id = 5, Name = "Sohan" };

      bool k = l.Contains(cc);

        Console.WriteLine(k);

        Customadd kk = new Customadd();
        l.Sort(kk);
        foreach(Customer c in l)
        {
            Console.WriteLine(c.Id + " " + c.Name);
        }
    }
}