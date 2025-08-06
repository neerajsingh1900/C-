using System;


public class Program
{
    public static void Main(string[] args)
    {
        SortedList<int,string> s  = new SortedList<int, string>();
        s[2] = "n";
        s[0] = "a";
        s[89] = "d";
        s[60] = "m";    
        foreach(int i in s.Keys)
        {
            Console.WriteLine(i + " : " + s[i]);    
        }

        HashSet<int> ints = new HashSet<int>();

        ints.Add(9);
        ints.Add(2);    
        ints.Add(8);    
        ints.Add(4);    
        foreach(int i in ints)
        {
            Console.WriteLine(i);
        }

        HashSet<int> k = new HashSet<int>() {4,7,8,9 };

        ints.UnionWith(k);
        foreach(int i in ints)
        {
            Console.WriteLine(i);
        }

        ints.IntersectWith(k);
    
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }

    }
}