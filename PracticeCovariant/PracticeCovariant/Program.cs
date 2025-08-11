using System;


interface IGen< out T>
{
    T Get(int id);  
}

public class Gen<T>:IGen<T>
{
    public T val { get; }
    public T Get(int id)
    {

        Console.WriteLine(id);

        return val;
    }
}


interface Isec<in T>
{
    void Show(T val);
}

public class sec<T>:Isec<T>
{
    public void Show(T val)
    {
        if (val is Child)
        {
            Child cc = val as Child;
            
            Console.WriteLine($"{cc.ChildId}");
        }
        else
        {
           
            Console.WriteLine($"{(val as Parent).Id}");
        }
    }
}

public class Parent
{
    public int Id { get; set; } 
}

public class Child : Parent
{
    public int ChildId { get; set; }
}
public class Child1 : Parent
{
    public int ChildId { get; set; }    

}

public class Program
{
    static void Accept(IEnumerable<Object> list)
    {
        foreach (Object obj in list)
        {
            Console.WriteLine(obj);
        }
    }

    public static void Main(string[] args)
    {

        IGen<Parent> p = new Gen<Child>();
        Parent pp  = new Parent() { Id=9};
         
      Parent j =  p.Get(1);
        //   Console.WriteLine(j.Id);

        Accept(new List<string>() { "one","two"});

        Child ii = new Child() { ChildId=9 };
        Child1 kkk = new Child1() { ChildId =10};  

        Isec<Child> isec = new sec<Parent>();    
        isec.Show(ii);
        Isec<Child1> isec1 = new sec<Parent>();
        isec1.Show(kkk);

    }
}