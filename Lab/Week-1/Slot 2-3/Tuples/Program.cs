using System;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string MyString, int MyNumber) MyValues = ("Hello World !", 2050);
            Console.WriteLine($"MyString: {MyValues.MyString}");
            Console.WriteLine($"MyNumber: {MyValues.MyNumber}");
            Console.ReadLine();
        }
    }
}
