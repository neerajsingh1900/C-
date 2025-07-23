using System;


public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your Name:");
        string name = Console.ReadLine();   

        CD c = new CD();
        c.Artist = "AR Rehman";
        c.Title = "Song";
        c.NumberOfTracks = 8;
        c.LoanPeriod = 14;
        c.Borrower = name;

        c.Print();
        c.Borrow(name);
        c.Return();
        c.Borrow("Sumit"); 

        DVD d = new DVD();
        d.LoanPeriod = 7;
        d.Borrower = name; 
        d.Director = "Sonu Nigam";
        d.LengthInMinutes = 10;
        d.Title = "Video Song";
        d.Print();  

        Book b = new Book();
        b.Borrower = name;
        b.Author = "J K Rowlin";
        b.Title = "Rich Dad Poor Dad";
        b.LoanPeriod = 21;
        b.ISBN = "Affiliated by AION";
        b.Print();

    }
}