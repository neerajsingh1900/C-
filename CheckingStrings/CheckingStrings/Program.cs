using System;

public class Program
{
    public static void Main(string[] args)
    {

    string a = "Neeraj";

    bool check = a.StartsWith("Nee");

        Console.WriteLine(check);

        check = a.EndsWith("aj");
        Console.WriteLine(check);

        check = a.Contains("ra");
        Console.WriteLine(check);

        int index = a.IndexOf("e");
           index = a.IndexOf("e",2);
        index = a.IndexOf("d");
        Console.WriteLine(index);

        index = a.IndexOf('e', a.IndexOf('e') + 1);
        Console.WriteLine(index);   





    }

}