using System;


public class DownloadDetail : EventArgs
{
    public string Filename {  get; set; }   
    public int size {  get; set; }  
}

public class Website
{
    public string Name { get; set; }   
    
    //creating event
    public event EventHandler<DownloadDetail> Myeve;

    //calling event
    public void RaiseNotification()
    {
        Myeve(this,new DownloadDetail() { Filename="Mirzapur",size=489});
    }



}