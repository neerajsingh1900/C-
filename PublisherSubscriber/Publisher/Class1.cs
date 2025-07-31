using System;


public delegate void dell(int a, int b);
public delegate void calI(int interest);

public class Publisher
{
    dell d;
    calI i;
   
 public event dell myeve
        {

        add
        {
            d += value;
        }
        remove
        {
            d-=value;
        }
    }
    public event calI myeve2
    {

        add
        {
            i += value;
        }
        remove
        {
            i -= value;
        }
    }


    public void RaiseEvent(int x,int y)
    {
        d(x,y);
    }
    public void Invoke(int x)
    {
        i(x);
    }

}