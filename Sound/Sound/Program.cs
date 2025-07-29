using System;


    public interface ISound
    {
        void Sound();
    }

   
    public class Dog : ISound
    {
        public void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Car : ISound
    {
        public void Sound()
        {
            Console.WriteLine("Car honks");
        }
    }

    public class Man : ISound
    {
        public void Sound()
        {
            Console.WriteLine("Man speaks");
        }
    }

    public class Cat : ISound
    {
        public void Sound()
        {
            Console.WriteLine("Cat meows");
        }
    }

   
    public class GEN<T> where T : ISound, new()
    {
        public void MakeSound()
        {
            ISound a = new T(); 
            a.Sound();          
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Car");
            Console.WriteLine("3. Man");
            Console.WriteLine("4. Cat");
            Console.Write("Enter your choice (1-4): ");

            string input = Console.ReadLine();

           
            GEN<Dog> g1;
            GEN<Car> g2;
            GEN<Man> g3;
            GEN<Cat> g4;

         
            switch (input)
            {
                case "1":
                    g1 = new GEN<Dog>();
                    g1.MakeSound();
                    break;
                case "2":
                    g2 = new GEN<Car>();
                    g2.MakeSound();
                    break;
                case "3":
                    g3 = new GEN<Man>();
                    g3.MakeSound();
                    break;
                case "4":
                    g4 = new GEN<Cat>();
                    g4.MakeSound();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

