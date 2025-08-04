using System;


public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[8];


        a[0] = 9;
        a[1] = 10;  
        a[2] = 1;

        for(int i=0;i<a.Length;i++)
        {
            Console.WriteLine(a[i]);
        }


        string[] b = new string[7] {"one","two","three","four","five","six" ,"seven"};

        for(int i=0;i<b.Length;i++)
        {
            Console.WriteLine (b[i]);   
        }
        int ind = Array.IndexOf(b, "three");
        Console.WriteLine(ind);

        int id = Array.IndexOf(b,"five",2);
        Console.WriteLine(id);

        int s = Array.BinarySearch(a,1);
        Console.WriteLine(s);
        Array.Clear(a, 0, 4);
        foreach(var i in a)
        {
            Console.WriteLine((int)i);
        }


        //2d
        int[,] e = new int[3, 2] {
            { 1,2 },
            { 4,5},
            { 7,8}
        };

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine(e[i,j]);
            }
        }


        //3d
        int[,,] arr = new int[3, 2, 4] {
            {
                {1,2,3,4 },
                { 5,6,7,8}
            },
            {
                {9, 10,11,12 },
                { 13,14,15,16}
            },
            {
                { 17,18,19,20},
                {21,22,23,24 }
            }
        };

        //manual assign
        arr[0, 1, 2] = 9;


        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                for(int k = 0; k < 4; k++)
                {
                    Console.Write(arr[i, j, k] + " ");

                }
                Console.WriteLine();    
            }
            Console.WriteLine();
        }

        //4d
        int[,,,] arrr = new int[2, 2, 3, 2]
        {
            {
                {
                    { 1,2},
                    {3,4 },
                    { 5,6}
                },
                {
                    { 1,2},
                    {3,4 },
                    { 5,6}
                }
            },
            {
                {
                    { 1,2},
                    {3,4 },
                    { 5,6}
                },
                {
                    { 1,2},
                    {3,4 },
                    { 5,6}
                }
            }
        };
       
    }
}