using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Welcome to C#.NET Programming";
            Console.WriteLine("{0}",msg);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg: {args[i]}");
            }
            Console.ReadLine();
        }
    }
}
