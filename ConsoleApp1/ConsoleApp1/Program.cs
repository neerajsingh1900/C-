using Microsoft.VisualBasic;
using System;
using System.Numerics;
public class Programming
{
    //feet to centimeters 
    public static void Conversion()
    {

        double height = double.Parse(Console.ReadLine());
        int feet = (int)height;
        Console.WriteLine(feet);
        double inch = (height - feet) * 12;
        Console.WriteLine(inch);
        double cm = (feet * 30.48) + (inch * 2.54);
        Console.WriteLine(cm);
    }

   //Area of Circle
    public static void Area()
    {
        float r = float.Parse(Console.ReadLine());
        float area = (22f/7f)*r* r;
        System.Console.WriteLine(area);


    }

    //largest of three numbers 

    public static void Largest()
    {
        int a = int.Parse(Console.ReadLine());
       int b = int .Parse(Console.ReadLine());  
    int c = int .Parse(Console.ReadLine());

        if (a > b && a > c) Console.WriteLine("a is largest");
        else if (b > c) Console.WriteLine("b is largest");
        else Console.WriteLine("c is largest");
    }
    
    public static void Main(string[] args)
    {
       // Area();
       // Conversion();
        Largest();

    }
}