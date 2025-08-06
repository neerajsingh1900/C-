using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Add your products to order");

        int choice;
        Order o = new Order() { Id =1};
        o.p = new List<Product>();
        Product p1;

        do
        {
            Console.WriteLine("Enter the product Details:");
            p1 = new Product();
            Console.WriteLine("Product id:");
            p1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Product Name:");
            p1.Name = Console.ReadLine();

            o.p.Add(p1);


            Console.WriteLine("if you do not wish to continue then press -1");

            choice = int.Parse(Console.ReadLine());
        } while (choice != -1);



        Console.WriteLine("Your order list of:" + o.GetHashCode + o.Id + "are :");


        foreach(Product i in o.p)
        {
            Console.WriteLine("Product id :" + i.Id + " " +  i.Name); 
        }
    }
}