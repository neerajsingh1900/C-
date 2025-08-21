using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder();

        string[] ss = new string[] {"one","two","three","four","five","six","seven","eight","nine","ten" };
        
        foreach(string i in ss)
        {
            s.Append(i + " ");
            
            Console.WriteLine(s.Capacity);
        }

        string final = s.ToString();    
        Console.WriteLine(final);


        // CONSTURCTORS AVAILABLE
        StringBuilder strb = new StringBuilder(18);
        Console.WriteLine(strb.Capacity);

        StringBuilder strr = new StringBuilder("old",19);
        Console.WriteLine(strr + " " + strr.Capacity);


        //METHODS
        strb.Append("First Addition");  
        Console.Write(strb);

        strb.Insert(2,"Second Addition");
        Console.WriteLine(strb);

        strb.Remove(2, 15);
        Console.WriteLine(strb);

        strb.Replace("F","S");
        Console.WriteLine(strb);

        //PROPERTIES
        Console.WriteLine("PROPERTIES");
        int len = strb.Length;  
        Console.WriteLine($"Length: {len}  Capacity: {strb.Capacity}" +
            $" MaxCapacity: {strb.MaxCapacity} element: {strb[0]}" );



    }
}