using System;


public class Program
{

   static void Print(List<int>a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
    public static void Main(string[] args)
    {
        List<int> a = new List<int>(10) { 10, 20, 30, 40 };

        foreach (int i in a)
        {
            Console.WriteLine(i);
        }

        Print(a);
        a.Add(50);
        List<int> a1 = new List<int>(10) { 80, 90, 100 };

        a.AddRange(a1);
        a.Insert(2, -9);
        Console.WriteLine();
        Print(a);
        // REMOVE METHODS

        //1. remove(t)
        Console.WriteLine() ;
      bool p =  a.Remove(90);
        Console.WriteLine(p);
       Print(a);

        //2.RemoveAt
         a.RemoveAt(2);
        Console.WriteLine();
        Print(a);


        //3.RemoveRange
        a.RemoveRange(2, 3);
        Console.WriteLine();    
        Print(a);

        //4.removeall

        a.RemoveAll(val => val > 20);
        Console.WriteLine();    
        Print(a);

        a.Clear();
        Console.WriteLine();

        a.Add(90);
        a.AddRange(new List<int> { -1, -2, -3, -4,-3 });
        Print(a);



      int K=  a.IndexOf(-3, 4);
        Console.WriteLine(K);

        List<int> an = new List<int>() {1,2,3,5,4,6 };


     Console.WriteLine(an.BinarySearch(5));


        Console.WriteLine();
        an.Sort();
        Print(an);

        Console.WriteLine();
        an.Reverse();
        Print(an);




        // toarray and foreach

        List<int> and = new List<int>() { 30, 40, 50, 60 };

        Console.WriteLine();
      int[] anarr=  and.ToArray();

        foreach(int i in  anarr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine() ;
        and.ForEach(val =>
        {
            Console.Write(val * 10 + " ");
        }) ;

    }
}