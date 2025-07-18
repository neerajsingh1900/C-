using System;

using LinkingFile;
class Modifier: LinkingFile.Class1
{
    public static void Show()
    {

        Class1.DoubleChange(out int g);
        Console.WriteLine(g);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        LinkingFile.Class1 l = new LinkingFile.Class1();
        l.SetTax(tax:78);
        l.SetTotal(65);
        LinkingFile.Class1 nn = new LinkingFile.Class1();
        nn.SetTax(tax:33);
        nn.SetTotal(87);



        Console.WriteLine(LinkingFile.Class1.All(l, nn));


        double q = 89.98;
        Console.WriteLine(q);

        Class1 cll = new Class1();
        cll.change( percentage: ref q);
        Console.WriteLine(q);

        Modifier.Show();


    }
}