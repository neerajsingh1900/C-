using System;

public class Engineer
{
    public int id {  get; set; }    
    public string name { get; set; }    

    public Engineer DeepCopy()
    {
        Engineer e = new Engineer() {id = this.id,name = this.name };

        return e;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Engineer e = new Engineer() { id=9,name ="Neeraj"};
        Engineer e2 = new Engineer();
        Engineer e3;

        Engineer[] eng = new Engineer[]{e,
        new Engineer(){ id=8,name="Sumit"},
        new Engineer() };

        eng[2].id = 77;
        eng[2].name = "Hritik";


        //performing deep copy
        Engineer[] eng2 = new Engineer[3];


        for(int i=0;i<eng.Length;i++)
        {
      eng2[i] = eng[i].DeepCopy();
            // we can also perform deep copy by implementing IClonable interface mthod

        }  

        //now dispaly of both
        foreach(Engineer i in eng)
        {
            Console.WriteLine(i.id + " " + i.name); 
        }

        foreach (Engineer i in eng2)
        {
            Console.WriteLine(i.id + " " + i.name);
        }

        // now changing 2nd and seeing 1st there would not be any changes

        eng2[0].id = 888;
        foreach (Engineer i in eng)
        {
            Console.WriteLine(i.id + " " + i.name);
        }

        foreach (Engineer i in eng2)
        {
            Console.WriteLine(i.id + " " + i.name);
        }
    }
}