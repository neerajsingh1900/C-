using System;

public class Counting
{
    public void Countup()
    {
        for(int i=0;i<=100;i++)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;    
            Console.Write(i + " ");
        }
    }

    public void Countdown()
    {
        for (int i = 100; i>=0; i--)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i+ " ");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
       Thread main =  Thread.CurrentThread;
        main.Name = "Threadofmine";
        
        Console.WriteLine(main.Name.ToString());

        Counting c = new Counting();

        //countup delegate 
        ThreadStart th = c.Countup;

        //countdown delegate
        ThreadStart tt = c.Countdown;


        Thread first = new Thread(th);
        first.Name = "UP thread";
        Console.WriteLine($"Thread in {first.ThreadState} state");

        first.Start();
        Console.WriteLine($"Thread in {first.ThreadState} state");

        Thread second = new Thread(tt);
        second.Name = "Down thread";
        Console.WriteLine($"Thread in {second.ThreadState} state");

        second.Start();
        Console.WriteLine($"Thread in {second.ThreadState} state");

        Console.WriteLine("Main thread stopped");
    }
}