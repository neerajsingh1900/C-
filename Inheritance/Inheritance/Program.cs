using System;

public class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee(11,"person 0","viman nagar","South");

        //e.Name = "Person 1";
        //e.Id = 123;
        //e.Location = "Viman Nagar";
        //e.Region = "East";

         
        //initializing the base class constructor 
        Manager m = new Manager(67,"wadgaon", 123, "person 2", "Wadgaon Sheri", "West");
        //METHOD HIDING
        m.Show();
        m.Got();
        //m.Id = 79;
        //m.Name = "Mahendra";
        //m.Location = "Wadgaon";
        //m.Region = "West";

        Chilld c = new Chilld(1, "pp", 4, "done", "sheri", "badarpur");
        c.Got();

        Salesman s = new Salesman(34,"rohan mehra","delhi","south");
        s.Location = "Kharadi";
        s.Name = "Sohan";
        s.Id = 90;
        s.Region = "North";



        // constructor by default called and properties inherited
        System.Console.WriteLine(s.Name);
        System.Console.WriteLine(s.Id);
        System.Console.WriteLine(s.Location);
        System.Console.WriteLine(s.Region);
        s.GetSalesOfCurrentMonth();


        System.Console.WriteLine(m.Name);
        System.Console.WriteLine(m.Id);
        System.Console.WriteLine(m.Location);
        System.Console.WriteLine(m.Region);
        System.Console.WriteLine(m.Manager_dep);
        System.Console.WriteLine(m.Manager_loc);
        m.gettotalsalesofyear();


        System.Console.WriteLine(e.Name);
        System.Console.WriteLine(e.Id);
        System.Console.WriteLine(e.Location);
        System.Console.WriteLine(e.Region);

    }
}