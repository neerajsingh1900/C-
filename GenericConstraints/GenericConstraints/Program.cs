using System;


public class Program
{
    public static void Main(string[] args)
    {
        Gen<Student> g = new Gen<Student>();

        g.Show();   

        Methodss m = new Methodss();    
        string name = "Test";
        int age = 9;
        m.Join<string>(name);
        m.Join<int>(age);   
    }
}