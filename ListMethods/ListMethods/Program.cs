using System;


public class Program {
   public static void Main(string[] args)
    {
        List<int> a = new List<int>() { 1,2,3,4,5,6};


        bool b = a.Exists(x => x == 7);
        Console.Write(b);

        Console.WriteLine();
        int ans = a.Find(x => x > 4);
        Console.WriteLine(ans);

        ans = a.Find(x => x > 6);
        Console.WriteLine(ans);


        int ind = a.FindIndex(X => X > 4);
        Console.WriteLine(ind); 
    }
}
