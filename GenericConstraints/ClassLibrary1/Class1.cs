using System;

public abstract class Address
{
    public int pincode = 8;
    public abstract void Display();


}

public class Student:Address
{
    public int pincode = 9;
    public override void Display()
    {
        System.Console.WriteLine("Checking for ADDRESS");
    }
}

public class Gen<T> where T : Address
{
    public T stu;

    public void Show()
    {
       // stu = new Student();
      //  System.Console.WriteLine(stu.pincode);
        Address a = (Address)stu;
        a = new Student();
        System.Console.WriteLine(a.pincode);
        a.Display();
    }
}

public class Methodss
{
    public void Join<T>(T o)

    {

        if (o.GetType() == typeof(string))
        {
            System.Console.WriteLine("it is a string");
        }
        else if (o.GetType() == typeof(int))
        {
            System.Console.WriteLine("it is int");
        }

    }
}