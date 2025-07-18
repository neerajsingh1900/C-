//using System;
//class Done
//{
//    private int grade = 999;
//    internal void Join(out int a, ref int k)
//    {
//        a = 9;
//        k++;
//        Console.WriteLine(a + " " + k);
//    }

//    internal void Change(in int l)
//    {
//       // l++;
//        Console.WriteLine((l));
//    }

//    public  void Showing()
//    {
//        Console.WriteLine(this.grade);
//    }
//    public ref int Inner()
//    {
//        return ref grade;
//    }

//    public void Arrayy(params int[] a)
//    {
//            int maxi=0;
//        for(int i = 0; i < a.Length; i++)
//        {
//            if (maxi < a[i])
//            {
//                maxi = a[i];
//            }
//        }
//        Console.WriteLine("Max value is: " + maxi);
//    }

//    public void Recursive(int n,ref int sum)
//    {
//        if (n == 0) { return;

//        }
//        sum += n;
//        Recursive(n - 1,ref sum);
//    }
//}

//public class Progress
//{
//    public static void Main(string[] args)
//    {
//        int p = 0;
//        Done d = new Done();
//        int j = 9;
//        d.Join(out p, ref j);
//        Console.WriteLine(j);
//        int m = 11;
//        d.Change(in m);
//       d.Showing();
//        ref int gr = ref d.Inner();
//        gr = 89;    
//        d.Showing();

//        d.Arrayy(9, 88, 98, 7, 6, 987, 6, -9, 78);
//        Console.ReadKey();
//        int s = 0;
//        d.Recursive(9,ref s);
//        Console.WriteLine(s);

//    }
//}
using System;

public class Program
{
    public int a = 0;

    public static void Change(in int l)
    {
        Console.WriteLine("o");
        //l=9;
    }

}

public class Show
{
    public static void Main(string[] args)
    {
        // Program m = new Program();
        //int l =0;
        int l = 8;
        Program.Change(in l);
        // Console.WriteLine(m.a);

    }
}