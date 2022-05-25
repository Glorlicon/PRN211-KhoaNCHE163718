using System;

namespace Singleton_Pattern
{
    public sealed class Singleton {
        private static readonly Singleton Instance;
        private static int TotalInstance=0;
        private Singleton()=> Console.WriteLine("--Private constructor is called ")
        static Singleton()
        {
            Console.WriteLine("--static Constructor is called.");
            Instance = new Singleton();
            TotalInstance++;
            Console.WriteLine($"--Singleton instances is created. Number of instances:{ TotalInstance}");
            Console.WriteLine("--Exit from static constructor");
        }
        public static Singleton GetInstacne => Instance;
        public int GetTotalInstance => TotalInstance;
        public void Print() => Console.WriteLine
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1.Trying to get a Singleton instance, called firstInstance.");
            Singleton firstInstance = Singleton.GetInstacne();
            firstInstance.Print();
            Console.WriteLine("#2.Trying to get another Singleton instance, called secondInstance.");
            Singleton secondInstance = Singleton.GetInstacne();
            Console.WriteLine($"Number of instances:{secondInstance.GetTotalInstance}");
            Console.Write("--Invoke Print() method : ");
            secondInstance.Print();
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("=> The firstInstance and secondInstance are the same.");
            }
            else
            {
                Console.WriteLine("=> Different instances exist.");
            }
            Console.Read();
        }
    }
}
