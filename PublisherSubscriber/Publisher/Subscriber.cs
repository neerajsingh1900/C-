using System;


public class Subscriber
{
   public int interest;
    public int balance;
    public void Add(int a,int b)
    {
        this.interest++;
        Console.WriteLine(interest+" " +a + ", " + b);
    }

    public void CalInterest(int interest)
    {
        balance = balance + balance*interest;
        Console.WriteLine(interest+" " +balance);
    }

}