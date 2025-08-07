using System;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> m = new Dictionary<int, string>()
        {
            {101,"neeraj" },
            {102,"amit" }
        };

        m[109] = "sumit";


        foreach (KeyValuePair<int, string> i in m)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }

        //duplicate key exception at runtime
        //m.Add(102, "song");

        Dictionary<int, string>.KeyCollection j = m.Keys;


        foreach (int i in j)
        {
            Console.WriteLine(i);
        }
        Dictionary<int, string>.ValueCollection t = m.Values;

        foreach (string i in t)
        {
            Console.WriteLine(i);
        }
        m.Remove(101);
        foreach (KeyValuePair<int, string> i in m)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }

        bool ex =  m.ContainsKey(101);

        Console.WriteLine(ex);


        bool checkvalue = m.ContainsValue("sumit");
        Console.WriteLine(checkvalue);

        //clear
        m.Clear();
        foreach (KeyValuePair<int, string> i in m)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }
    }
}