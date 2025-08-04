using System;


public class User
{

    public void Information(Object sender,DownloadDetail e)
    {
        Console.WriteLine($"File name is {e.Filename}");
        Console.WriteLine($"File size is :{e.size}");

        Website w = (Website)sender;

        Console.WriteLine($"Website Downloaded from:{w.Name}");
    }
}