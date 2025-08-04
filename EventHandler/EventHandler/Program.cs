using System;


public class Program {

    public static void Main(string[] args)
    {
        Website w = new Website();
        w.Name = "Bollyflix";
        User   user = new User();
        w.Myeve += user.Information;

        Website w1 = new Website();
        w1.Name = "Bolly4u";
        w1.Myeve += user.Information;

        w.RaiseNotification();
        w1.RaiseNotification(); 



    }
}