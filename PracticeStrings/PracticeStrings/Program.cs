using System;

public class Program
{
    public static void Main(string[] args)
    {
        string a = "developer@example.com";
        char[] arr = new char[] { 'a', 'e', 'i', 'o', 'u' };


      int cc =  a.Count(ch => Array.IndexOf(arr, ch)>=0);

        Console.WriteLine("Vowel Count:"+ cc);
        int count = 0;
        for(int i = 0; i < a.Length; i++)
        {

            if (Array.IndexOf(arr, a[i])>=0)
            count++;
        }

        Console.WriteLine("Vowel Count:" + count);
    }
}