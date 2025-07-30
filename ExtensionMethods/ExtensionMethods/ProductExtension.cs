using System;

public static class Extended
{
    public static int ProductMargin(this Product product)
    {
        Console.WriteLine($"Here you {product.Id} as {product.Name}");
        return product.Discount * 10;
    }
    public static void Show(this Product product)
    {
        Console.WriteLine("show 1");
    }
}