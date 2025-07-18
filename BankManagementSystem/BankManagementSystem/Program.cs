using System;


public class Programming
{
    public static void Main(string[] args)
    {
        Console.WriteLine("********Bank*********");

        Console.WriteLine("Enter Username:");

        string Username = null, Password = null;

        Username = Console.ReadLine();
        if (Username != "")
        {
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Enter Username First");
        }

        if (Username == "System" && Password == "123")
        {
            Console.WriteLine("Welcome to Main Menu:");
            int n = -1;

            do
            {
                Console.WriteLine("\n Choose Your Choice:");
                Console.WriteLine("1.Customer");
                Console.WriteLine("2.Account");
                Console.WriteLine("3.Fund Transfer");
                Console.WriteLine("4.Fund Transfer Statements");
                Console.WriteLine("5.Account Statements");
                Console.WriteLine("0.Exit");
                n = int.Parse(Console.ReadLine());



                switch (n)
                {
                    case 1: CustomerManage();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;

                }
            } while (n != 0);
        }


        else
        {
            Console.WriteLine("Invalid Username or Password");
        }

        static void CustomerManage()
        {


            int a = -1;
            do
            {
                Console.WriteLine("\n Choose Your Choice:");
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Delete Customer");
                Console.WriteLine("3.Modify Customer");
                Console.WriteLine("0.Exit");

                a = Convert.ToInt32(Console.ReadLine());


                switch (a)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (a != 0);
        }


        Console.WriteLine("Thankyou Visit Again!");
        Console.ReadKey();
    }
}