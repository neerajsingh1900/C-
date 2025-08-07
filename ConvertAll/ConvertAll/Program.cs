using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> l = new List<int>() { 1,2,3,4,5,6,7};

      List<string> s =  l.ConvertAll(x => "Number :" + x);

        foreach(string i in s)
        {
            Console.Write(i + " ");
        }


    }
}