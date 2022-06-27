using System;

namespace ConsoleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("Data parsing");
            Console.Write("Enter a String value: ");
            s = Console.ReadLine();
            Console.Write("Enter a Integer value: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter a Double value: ");
            d= double.Parse(Console.ReadLine());
            Console.Write("Enter a Date value: ");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"s:{s}, i:{i}, d:{d}, date:{date:dd/MM/yyyy}");
        }
    }
}
