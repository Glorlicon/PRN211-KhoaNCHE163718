using System;

namespace Local_function_and_static_local_function_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void AreaOfCircle(double a)
            {
                double ar;
                Console.WriteLine("Radius of the circle: "+a);
                ar = 3.14 * a * a;
                Console.WriteLine("Area of circle: " + ar);
                Circumference(a);
                static void Circumference(double radii)
                {
                    double cr;
                    cr = 2 * 3.14 * radii;
                    Console.WriteLine($"Circumference of the circle is:{cr:N2}");
                }
            }
            AreaOfCircle(10);
            Console.ReadLine();
        }
    }
}
