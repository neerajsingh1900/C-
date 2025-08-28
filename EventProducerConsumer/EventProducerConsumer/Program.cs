using System;
public class Shared
{
    public static int[] data {  get; set; } 
    public static int BatchCount {  get; set; }  

    public static int Batchsize {  get; set; }  

    public static ManualResetEvent m {  get; set; } 
    
    static Shared()
    {
        data = new int[15];
        BatchCount = 5;
        m = new ManualResetEvent(false);    
        Batchsize = 3;
    }
}

public class Producer
{
    public void Produce()
    {

        for (int i = 0; i < Shared.Batchsize; i++)
        {
            Console.WriteLine($"{i+1} batch producer");

            for (int j = 0; j < Shared.BatchCount; j++)
            {
                Shared.data[i*Shared.BatchCount +j ] = 
                    i * Shared.BatchCount + j + 1;

                //without sleep it will be so fast like 
                //it will call set 3 times even wait() have not queued for
                //3 times and they will lose the signal, deadlock
                //it allow other threads to run
                //Thread.Sleep(300);
            }
                Thread.Sleep(3000);

            //i am signalling here that all the waiting thread for 
            //this shared resource could go 
        
            Shared.m.Set();

          

        }
    }
}
    public class Consumer
    {
        //keeps waiting before setting 
        public void Consume()
        {

        for (int i = 0; i < Shared.Batchsize;i++)
        {
            Console.WriteLine($"{i + 1} batch consumer");
            // i was waiting for the signal to access a shared resource
            Shared.m.WaitOne();
            for (int j = 0; j < Shared.BatchCount; j++)
            {
                Console.WriteLine(Shared.data[i* Shared.BatchCount + j]);
                Console.WriteLine("times");
            }
            //after set , again block
            Shared.m.Reset();

        }

        }
    }

public class Program
{
    public static void Main(string[] args)
    {
        Producer p = new Producer();    

            ThreadStart tt = p.Produce;
        Consumer c = new Consumer();
        ThreadStart th = c.Consume;


        Thread producer = new Thread(tt);
        Thread consumer = new Thread(th);

        producer.Start();   
        consumer.Start();   
    }
}