using System;

public class Shared
{
    public static int Count {  get;  set; }
    public static int buffercapacity = 5;
    public static Object lockobj = new Object();
    public static Queue<int> buffer = new Queue<int>();

    public static void Print()
    {
        Console.Write("Buffer:");
        foreach(int i in buffer)
        {
            Console.Write(i + " ");
        }
    }
}


// PULSEALL() used to allow all the threads
public class Producer
{
    public void Produce()
    {
            
         for (int i = 0; i < 10; i++)
            {
            Console.WriteLine("in producer state");
        
            //to allow all waiting threads be in queue
           Thread.Sleep(2000);
        lock (Shared.lockobj)
        {

              if (Shared.buffer.Count == Shared.buffercapacity)
            {
                Monitor.Wait(Shared.lockobj);
            }
                    Shared.buffer.Enqueue(i + 1);

                Shared.Print(); 

  //just as this signal goes lock is aquired by another thread
  //and wait is executed forward 
                Monitor.Pulse(Shared.lockobj);  
            }

        Console.WriteLine("Producer completed");
        }
    }
}


public class Consumer
{
    public void Consume()
    {

           for(int i=0;i<10;i++)
            {
            Console.WriteLine("In consumer state");
            //to allow all waiting to be in queue
     
            Thread.Sleep(1000);
            lock (Shared.lockobj)
        {
                if (Shared.buffer.Count == 0)
                {
                    Monitor.Wait(Shared.lockobj);
                }

                
             var val=  Shared.buffer.Dequeue();
                //  Shared.Print();
                Console.WriteLine(val);
             //will wake up the another thread wait state forcefuly
                Monitor.Pulse(Shared.lockobj);  
        }
            Console.WriteLine("consumer completed");
        }
    }
}


public class Program
{
    public static void Main(string[] args) 
        {
        Producer p = new Producer();
        ThreadStart th = p.Produce;

        Consumer c = new Consumer();
        ThreadStart tt = c.Consume;


        Thread first = new Thread(th);
        Thread second  = new Thread(tt);

        second.Start();
        first.Start();

        first.Join();   
        second.Join();

        Console.WriteLine("main complete");
        
        } 
}