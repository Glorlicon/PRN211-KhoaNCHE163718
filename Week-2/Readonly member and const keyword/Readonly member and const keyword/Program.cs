using System;

namespace Readonly_member_and_const_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamplePoint p1 = new SamplePoint(11, 21, 32);
            Console.WriteLine($"t={SamplePoint.t}");
            Console.WriteLine($"p1: x={p1.x}, y={p1.y}, z={p1.z}");
            SamplePoint p2 = new SamplePoint();
            Console.WriteLine($"p2: x={p2.x}, y={p2.y}, z={p2.z}");
            Console.ReadLine();
        }
    }

    public class SamplePoint
    {
        public int x;

        public int y = 25;
        public int z;
        public const int t = 100;
        public SamplePoint()
        {
            z = 24;
        }
        public SamplePoint(int p1, int p2, int p3, int p4 = 50)
        {
            x = p1;
            y = p2;
            z = p3;
        }
    }
}
