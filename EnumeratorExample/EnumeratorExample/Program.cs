using System;


public class Program
{
        public static IEnumerable<int> Meth()
    {
        Console.WriteLine("order for buiscuit");
        Console.WriteLine("you have ordered:");
        yield return 10;

        Console.WriteLine("Want to add more");
        Console.WriteLine("Enter the buiscuit");
        yield return 20;    

    }
    public static void Main(string[] args)
    {
        // List<string> s
        IEnumerable<string> s;
        s = new List<string>() { "one", "two", "three", "four" };


        // compensating foreach loop
        IEnumerator<string> e = s.GetEnumerator();

        e.Reset();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }

    // Yield Return example
    IEnumerator<int> a = Meth().GetEnumerator();

        // we could use foreach this as it is of type ienumerable
        //foreach(int i in Meth())
        //{
        //    Console.WriteLine(i);
        //}


        // now doing manually
        a.MoveNext();
        Console.WriteLine(a.Current);
        a.MoveNext() ;  
        Console.WriteLine(a.Current);



    }


    
}