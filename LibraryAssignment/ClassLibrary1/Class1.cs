using System;
using System.IO;


interface ILonable
{
     int LoanPeriod {  get; set; }
     string Borrower {  get; set; }

    void Borrow(string b);

    void Return();
}

interface IPrintable
{
    void Print();
}

public class Book : ILonable, IPrintable
{
    public string Author { get; set; }
    public string Title { get; set; }
    public string ISBN{ get; set; }
    public string Borrower { get; set; }    
    public int LoanPeriod { get; set; } 

    public  void Borrow(string b)
    {
        if (Borrower == "")
        {
            Borrower = b;
            System.Console.WriteLine($"Book is now Borrowed by: {Borrower}");

        }
        else
        {
            System.Console.WriteLine("Already the Book is Borrowed");
        }
    }

    public void Return()
    {
        if (Borrower != "")
        {
            Borrower = "";
            System.Console.WriteLine($"{Title} Book Returned Successfuly!");
        }
        else
            System.Console.WriteLine("Book Not Borrowed");

    }

    public void Print()
    {
        System.Console.WriteLine($"Book {Title} of Author :{Author} is Borrowed by :{Borrower} for {LoanPeriod}");
    }

}

public class DVD : IPrintable, ILonable
{
    public string Director { get; set; }
    public string Title { get; set; }
    public int LengthInMinutes { get; set; }

    public int LoanPeriod { get; set; }

    public string Borrower { get; set; }


    public void Borrow(string b)
    {
        if (Borrower == "")
        {
            Borrower = b;
            System.Console.WriteLine($"DVD is now Borrowed by: {Borrower}");

        }
        else
        {
            System.Console.WriteLine("Already the DVD is Borrowed");
        }
    }

    public void Return()
    {
        if (Borrower != "")
        {
            Borrower = "";
            System.Console.WriteLine($"{Title} by {Director} DVD Returned Successfuly!");
        }
        else
            System.Console.WriteLine("DVD Not Borrowed");

    }

    public void Print()
    {
        System.Console.WriteLine($"DVD: {Title} of Director :{Director} of Length :{LengthInMinutes} is Borrowed by :{Borrower} for {LoanPeriod}");
    }
}

public class CD: ILonable, IPrintable
{
    public string Artist {  get; set; } 
    public string Title { get; set; }   
    public int NumberOfTracks {  get; set; }

    public int LoanPeriod { get; set; }

    public string Borrower { get; set; }


    public void Borrow(string b)
    {
        if (Borrower == "")
        {
            Borrower = b;
            System.Console.WriteLine($"CD is now Borrowed by: {Borrower}");

        }
        else
        {
            System.Console.WriteLine("Already the CD is Borrowed");
        }
    }

    public void Return()
    {
        if (Borrower != "")
        {
            Borrower = "";
            System.Console.WriteLine($"{Title} by  Artist:{Artist} of {NumberOfTracks} Returned Successfuly!");
        }
        else
            System.Console.WriteLine("CD Not Borrowed");

    }

    public void Print()
    {
        System.Console.WriteLine($"CD: {Title} of Artist :{Artist} of Tracks :{NumberOfTracks} is Borrowed by :{Borrower} for {LoanPeriod}");
    }

}