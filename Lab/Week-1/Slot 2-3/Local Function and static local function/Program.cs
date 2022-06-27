using System;

namespace Local_Function_and_static_local_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine("Sum: {0}" , a+b+x+y);
                Console.WriteLine();
            }
            AddValue(3, 4);
            AddValue(5, 6);
            Console.ReadLine();
        }
    }
}
