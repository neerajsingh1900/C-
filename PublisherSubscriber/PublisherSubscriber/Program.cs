using System;


public class Program
{
    public static void Main(string[] args)
    {
        Subscriber s = new Subscriber();
        s.interest = 10;
        s.balance = 1000;
     
        Subscriber m = new Subscriber();   
        m.balance = 2000;
        m.interest = 20;
        Publisher p = new Publisher();
        //p.myeve += s.Add;
        //p.myeve += m.Add;
        p.myeve2 += s.CalInterest;


        p.Invoke(8);
        //p.RaiseEvent(10, 18);
        //p.RaiseEvent(99, 100);
    }
}