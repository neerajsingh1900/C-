using System;


public class Program
{

        static void Do()
    {
        using Database db = new Database();
        db.show();
    }

    public static void Main(string[] args)
    {
        Do();
        using (Database d = new Database())
        {
            d.show();
        }

        System.Console.WriteLine("here we could see that" +
            " it is called automatically!");
    }
}