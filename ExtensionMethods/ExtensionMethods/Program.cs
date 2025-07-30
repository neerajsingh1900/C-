using System;


public class Program
{
    public static void Main(string[] args)
    {
        Product p = new Product() { Discount =10, Id=9,Name="Neeraj singh" };
      int k =   p.ProductMargin();
        Console.WriteLine(k);
        p.Show();

        //var a = "sin";
        var a=10;
      //  Console.ReadLine(a);
        dynamic m = 10;
        Console.WriteLine(m);
        m = "do";
        Console.WriteLine(m);
    }
}