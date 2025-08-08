using System;
using System.Collections.Generic;
using System.Collections;

// custom collection 

    public class Customer
    {
        public int Id { get; set; }
        public string Name {  get; set; }  
    }

    public class Mycoll : IEnumerable

    {
        Customer c1 = new Customer() { Id=1,Name ="Neeraj Singh"};
        Customer c2 = new Customer() { Id = 2,Name= "Sumit Aggarwal" };
   
    
    
    // creating the collection over this field
         Customer[] c;
    public Mycoll()
    {
      c = new Customer[4];
        c[0] = c1;  
        c[1] = c2;  
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0;i<c.Length;i++)
        {
            yield return c[i];
        }
    }

    // we can add more methods into it like 
    public void Add(Customer l,int k)
    {
        c[k] = l;
    }
    }

public class Program
{
    public static void Main(string[] args)
    {

        // NOW Mycoll is a custom collection 

        Mycoll m = new Mycoll();
        //IEnumerator e = m.GetEnumerator();  
        //e.MoveNext();
        //Console.WriteLine( ((Customer)e.Current).Id + " " + ((Customer)e.Current).Name);
        //e.MoveNext();
        //Console.WriteLine(((Customer)e.Current).Id + " " + ((Customer)e.Current).Name);
   
        //we can use foreach loop over this collection


        m.Add(new Customer(){ Id = 22,Name = "Amit Kumar" }, 2);
        m.Add(new Customer() { Id = 32, Name = "yOOO Kumar" }, 3);
        foreach(Customer c in m)
        {
            Console.WriteLine(c.Id + " " + c.Name);
        }
    }

}