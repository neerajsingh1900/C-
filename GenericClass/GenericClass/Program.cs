using System;

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Roll no");
        string s = Convert.ToString(Console.ReadLine());
        Student<int> si;
        Student<char> ss;


        bool a;
        if (s != "")
        {

            si = new Student<int>();
            si.Marks = 98;
            a = true;
            System.Console.WriteLine(si.Marks);
        }
        else
        {
             ss = new Student<char>();
            ss.Marks = 'A';
            a = false;
            System.Console.WriteLine(ss.Marks); 
        }

      University<string,int> u = new University<string, int> ();
        u.staff = "Coditas";
        u.department = ".NET";
        u.Id = 90;

        University<bool,int> m = new University<bool, int> ();
        m.staff = true;
        m.department = false;
        m.Id = 91;

        System.Console.WriteLine(u.staff);
        System.Console.WriteLine(m.staff);

        System.Console.WriteLine(u.department);
        System.Console.WriteLine(m.department);
        
        System.Console.WriteLine(u.Id);
        System.Console.WriteLine(m.Id); 

    }
}