using System;
public class Program
{
    public static void Main(string[] args)
    {
      
        string a = "oNe";
        string b = a;
        a = "tWo";

        string upp = a.ToUpper();
        Console.WriteLine(upp);

        string down = a.ToLower();
        Console.WriteLine(down);    

            //Console.WriteLine(a);
            //Console.WriteLine(b);

        //string n = "Lamborgini";

    //SUBSTRING

        //string sub = n.Substring(2);
        //Console.WriteLine(sub); 
        //string subb = n.Substring(2,4);
        //Console.WriteLine(subb);

    //REPLACE

        //string kk = n.Replace("i", "j");
        //Console.WriteLine(kk);  
        //Console.WriteLine(n);


        //string mm = n.Replace("ink", "jni");
        //Console.WriteLine(" print: " +mm);

        //SPLIT - STRING TO STRING ARRAY

        string word = " how are you";

        string[] arr = word.Split(" ");
        
        //Console.WriteLine(arr.Length);
        //for(int i=0;i<arr.Length;i++)
        //{
        //    if (arr[i]=="")
        //    Console.Write("printing ");
        //}

    //TRIM

        //string lkl = word.Trim();

        //Console.WriteLine(lkl);

    // STRING TO  CHAR ARRAY

        char[] characters = word.ToCharArray();

        //foreach(char c in characters)
        //{
        //    Console.Write(c);
        //}
        //Console.WriteLine();


    // SPLIT AGAIN , STRING TO STRING ARRAY WITH CHAR SEPARATOR

        //string[] neww = word.Split("are");
        //foreach(string c in neww)
        //{
        //Console.WriteLine(c);

        //}


        // CHAR ARRAY TO STRING
        char[] chararray = { 'a', 'b', 'c', 'd' };

        string newstring = new string(chararray);

        Console.WriteLine(newstring);
       
       //JOIN FROM ARRAY TO STRING--static method
        string[] arrayofstring = ["one", "two", "three"];

        string joined = string.Join("---" , arrayofstring);

        Console.WriteLine(joined);  
    }
}