using System;



public class Counting
{
    public int Count { get; set; }  
    public void Countup()
    {
        try
        {
            for (int i = 0; i <= Count; i++)
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                  Console.Write(i + " ");
            }
        }
        catch (ThreadInterruptedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void Countdown()
    {
        for (int i = Count; i >= 0; i--)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i + " ");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Counting c = new Counting();

        c.Count = 100;

        //creating parameterized function
        ThreadStart th = c.Countup;


        //creating parameterized function
        ThreadStart tt = c.Countdown;

        //creating thread for the function
        Thread first = new Thread(th);


        //creating thread for the function
        Thread second = new Thread(tt);


        //calling
        first.Start();
        second.Start();

        Console.WriteLine("Main thread stopped");
    }
}