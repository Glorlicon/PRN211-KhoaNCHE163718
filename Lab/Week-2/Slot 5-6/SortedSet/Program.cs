using System;
using System.Collections.Generic;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> mySet = new SortedSet<int>() { 8,7,9,1,3};
            mySet.Add(5);
            mySet.Add(4);
            mySet.Add(6);
            mySet.Add(2);
            Console.WriteLine("Elements of mySet:\n");
            foreach (var val in mySet)
            {
                Console.Write($"{val,3}");
            }
            Console.ReadLine();
        }
    }
}
