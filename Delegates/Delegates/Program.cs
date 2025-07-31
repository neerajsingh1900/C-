using System;


public class Program
{
    public static void Main(string[] args)
    {
        Sample s = new Sample();

        Mydelegation m = new Mydelegation(s.Add);

      int k =   m.Invoke(6,7);
        Console.WriteLine(k);

        del d = s.Subtract;
        d += s.multiply;
        Console.WriteLine(d(9, 8));
    }
}