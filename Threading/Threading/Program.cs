using System;

public class Custom
{
    public int Id { get; set; } 
    public int count {  get; set; } 
}

    
public class Counting
{
    public void Countup(object? obj)
    {
        //Thread nn = Thread.CurrentThread;

      Custom c = (Custom)obj;
        int countt = c.count;
        int idd = c.Id;
        Console.WriteLine(idd);

        //Console.WriteLine("your name is :" + nn.Name);

        try
        {


            for (int i = 0; i <= countt; i++)
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");
                 //Thread.Sleep(1000);
            }

        }
        catch ( ThreadInterruptedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Countdown()
    {
        for (int i = 100; i>=0; i--)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i+ " ");
          //  Thread.Sleep(1000);
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
        //ThreadStart th = c.Countup;

        //way to pass parameter
        //ThreadStart th = new ThreadStart(() =>
        //{
        //    c.Countup(100);
        //}
        //    );


        //way to pass parameter
        ParameterizedThreadStart th = new ParameterizedThreadStart(c.Countup);

        //countdown delegate
        ThreadStart tt = c.Countdown;


        Thread first = new Thread(th);

        first.Name = "UP thread";

        //more properties

        first.Priority = ThreadPriority.Highest;

        // below property is automatically generated property
      Console.WriteLine(first.ManagedThreadId.ToString());

        Console.WriteLine($"Thread in {first.ThreadState} state");
        //calling
        //first.Start();

        //calling for parametrized
       // first.Start(100);

        //calling for parametrized threadstart
        first.Start(new Custom { Id=10,count=100});

        Console.WriteLine($"Thread in {first.ThreadState} state");

        Thread second = new Thread(tt);


        second.Name = "Down thread";
        second.Priority = ThreadPriority.BelowNormal;
        Console.WriteLine(second.ManagedThreadId);
        Console.WriteLine($"Thread in {second.ThreadState} state");

        second.Start();
        Console.WriteLine($"Thread in {second.ThreadState} state");

      //  first.Interrupt();
    //   first.Join();    
    //second.Join();  

    
        Console.WriteLine("Main thread stopped");


    }
}