using System;
using System.Collections;


public class Program
{
    public static void Main(string[] args)
    {
        Hashtable h = new Hashtable(3);

        h.Add(109, "Neeraj");
        h.Add(90.87m, "sober");
        h.Add("STring", 88);

        h.Add('a', 89);


        foreach (DictionaryEntry e in h)
        {

            Console.WriteLine(e.Key + " " + e.Value);
        }


        Console.WriteLine(Convert.ToInt32(h["STring"]));

        Console.WriteLine(h.ContainsKey('a'));
        Console.WriteLine(h.Count);

        Dictionary<int, string> d = new Dictionary<int, string>() { { 1, "neer" } };

        d[109] = "dd";
        d[-1] = "done";

        foreach(KeyValuePair<int,string> k in d)
        {
            Console.WriteLine(k.Key + " " + k.Value);
        }
    }
}