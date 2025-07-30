using System;


public class Product
{
    public int Id { get; set; } 
    public string Name { get; set; }    
    public int Discount {  get; set; }  

    public void Show()
    {
        Console.WriteLine("checking");
    }
}