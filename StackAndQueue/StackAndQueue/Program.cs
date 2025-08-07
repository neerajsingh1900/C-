using System;

public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> s = new Stack<int>();
        s.Push(8);
        s.Pop();
        s.Push(999);
        s.Push(89);

        int[] a = s.ToArray();

        foreach(int i in a)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        foreach (int i in s)
        {
            
            Console.Write(i + " ");
        }

        Queue<string> q = new Queue<string>();

        q.Enqueue("one");
        q.Enqueue("two");
        q.Enqueue("three");

        Console.WriteLine();
        foreach(string i in q)
        {
            Console.Write(i +" ");
        }


        string ele = q.Dequeue();  
        Console.WriteLine(ele);

        string e = q.Peek();

        Console.WriteLine(e);

        foreach (string i in q)
        {
            Console.Write(i + " ");
        }

    }
}