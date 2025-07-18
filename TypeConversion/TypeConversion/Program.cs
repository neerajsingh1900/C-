using System;


public class Program
{
    //implicit casting
    int a = 1;
    long b;

    //explicit casting
    long c = 10;
        
    double bi = 99.99;      
   


    public void Change() {
        b = a;
    int k = (int)c;
        System.Console.WriteLine(b + " " + c);

        //explicit double to int
        int e = (int)bi;
        Console.WriteLine(e); 
        
    }
    public static void Main(string[] args) { 
    Program p = new Program();
    p.Change();

        string a = "done1";
        string b = "done2";
        string l = "bool";

        //string to int
        int m = int.Parse(a);
        Console.WriteLine("provide an input");

        //input of string to int 
        bool k = int.TryParse(Console.ReadLine(), out int j);
        Console.WriteLine(j);

        //int to string 
        int f = 1;
        string s = Convert.ToString(f);
        Console.WriteLine(s);

        //string to int 
        int y = Convert.ToInt32(s);
        Console.WriteLine(y);

        //double to float

        double u = 89.79;

        float t = (float)u;
        Console.WriteLine(t);
        }


}

