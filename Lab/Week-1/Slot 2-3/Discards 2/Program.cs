﻿using System;

namespace Discards_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}:{last}");
            Console.ReadLine();
        }
        static (string first, string middle, string last) SplitNames(string fullname)
        {
            string[] strArray = fullname.Split(' ');
            return (strArray[0], strArray[1], strArray[2]);
        }
    }
}
