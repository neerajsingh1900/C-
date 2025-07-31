using System;

public class Sample
{
    public int Add(int a,int b)
    {
        return a + b;
    }
    public int Subtract(int a ,int b)
    {
        Console.WriteLine("subtract invoke");
        return a - b;
    }

    public int multiply( int a,  int b)
    {
        Console.WriteLine("multiply invoke");
        return a * b;
    }


}