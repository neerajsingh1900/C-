using System;


public class Program
{
  public static void Main(string[] args)
    {

        Publisher p = new Publisher();
        int a = 99;
        p.Eve += delegate (int x, int y)
        {
            //using instance variable
            Console.WriteLine(a+ x + y);
        };

        p.Eve += (a, b) =>
        {
            Console.WriteLine(a - b);
        };

        //p.Eve += (a, b) => a + b;

        p.Show(11, 12);


        // as a parameter
        p.Showing(delegate(int x,int y)
        {
            Console.WriteLine(a - y-x);   
        });

    }
}