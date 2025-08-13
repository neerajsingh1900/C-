using System;

    public delegate void Mydel(int x, int y);
public class Publisher
{
    //  public event Mydel Eve;
    //  public event Func<int, int, int> Eve;
    public event Action<int, int> Eve;
    public event Predicate<int> Ev;
    public void Show(int x,int y)
    {
        Eve(x, y);
    }


    public void Showing(Mydel m)
    {
        m(13, 15);
    }
}