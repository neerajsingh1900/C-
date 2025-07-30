using System;


public class Database:IDisposable
{
    public Database()
    {
        System.Console.WriteLine("Database connected");
    }

    public void show()
    {
        Console.WriteLine("showing the connection");
    }

    public void Dispose()
    {
        System.Console.WriteLine("database connection closed");
    }
   
}