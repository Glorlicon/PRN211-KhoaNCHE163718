using System;
using System.IO;

namespace DirectoryInfo_Class_Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\admin\source\repos");
            Console.WriteLine("Search pattern *a* returns:");
            foreach (var fi in di.GetDirectories("*a*"))
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Search pattern TopDirectoryOnly returns:");
            foreach (var fi in di.GetFiles("*.txt",SearchOption.TopDirectoryOnly))
            {
                Console.WriteLine(fi.Name);
            }
            Console.ReadLine();
        }
    }
}
