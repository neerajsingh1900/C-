using System;
public class Shared {
    public static int count {  get; set; }

    public static readonly Object lockobj= new Object();
}
public class Counting
{
    public void Countup()  
    {
        for (int i = 0; i < 100; i++)
        {
            // Monitor.Enter(Shared.lockobj);
            lock (Shared.lockobj)
            {
                Console.Write("In count up");
                Shared.count++;
                Console.Write(Shared.count + " ");
            }
          //  Monitor.Exit(Shared.lockobj);
        }
    }

    public void Countdown()
    {
        for (int i = 0; i < 100; i++)
        {
            //  Monitor.Enter(Shared.lockobj);
            lock (Shared.lockobj)
            {
                Console.Write("In count down");
                Shared.count--;
                Console.Write(Shared.count + " ");
            }
           // Monitor.Exit(Shared.lockobj);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {

        Shared.count = 0;
        Counting c = new Counting();

        ThreadStart th = c.Countup;
        ThreadStart th2 = c.Countdown;  

        Thread first= new Thread(th);
        Thread second= new Thread(th2); 

        first.Start();
        second.Start(); 
      
                first.Join();   
            second.Join();  
        Console.WriteLine("value is:" +Shared.count);
    }
}