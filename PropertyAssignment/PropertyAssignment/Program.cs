using System;

public class DebitCard
{


    private string _Pin;

    private bool correct(string pin)
    {
        for (int i = 0; i < pin.Length; i++) {
            if (pin[i]<48 || pin[i] > 57)
            {
                return false;
            }
        }
        return true;
    }
    public string Pin
    {
        set
        {
            if (value != null && value!="") {
                if ((value.Length != 4 || value.Length != 6) && value=="0")
                {
                    _Pin = "-1";
                    System.Console.WriteLine("here 1");
                }
                else if (!correct(value))
                {
                    _Pin = "-1";
                    System.Console.WriteLine("here 2");
                }
                else
                {
                    _Pin = value;
                    System.Console.WriteLine("here 3");
                }
                    }

            else
            {
                _Pin = "-1";  
            }
        }

        get
        {
            return _Pin;    
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DebitCard card = new DebitCard();

        string pin;
        System.Console.WriteLine("Enter Pin:");
        pin = Convert.ToString(Console.ReadLine());
        System.Console.WriteLine(pin);

        card.Pin = pin;

        if (card.Pin == "-1")
        {
            System.Console.WriteLine("INVALID! Please Enter Valid Pin no");
        }
        else
        {
            System.Console.WriteLine("Pin set successfully!");
        }
    }
}