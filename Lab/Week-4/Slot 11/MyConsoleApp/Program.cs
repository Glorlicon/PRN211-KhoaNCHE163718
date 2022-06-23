using System;
using static MyLibrary.MyClass;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 52;
            int result;
            Console.WriteLine("***** Demo Consuming Assemblies *****");
            result = a.Add(b);
            Console.WriteLine($"{a}+{b} = {result}");
            result = a.Sub(b);
            Console.WriteLine($"{a}-{b} = {result}");
            Console.ReadLine(); 
        }
    }
}
