using System;

public class Custom : InvalidOperationException
{
    public Custom(string message) : base(message)
    {

    }

    public Custom() 
    {

    }

    public Custom(string message,Exception innerex):base(message, innerex)
    {

    }
}

public class Bank
{
    public int balance=1000;
        public void withdrawbal(int bal)
    {
        if (bal > balance)
        {
            throw new Custom("invalid withdraw");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Bank b = new Bank();
            b.withdrawbal(9000);
        }
        catch (Custom c)
        {
            Console.WriteLine(c.Message);
        }
        finally
        {
            Console.WriteLine("finally block");
        }

        Console.WriteLine("program flow is maintained");

    }
}