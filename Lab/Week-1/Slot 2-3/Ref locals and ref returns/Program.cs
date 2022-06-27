using System;

namespace Ref_locals_and_ref_returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Original Sequence:");
            Console.WriteLine(String.Join(" ",numbers));
            ref int value = ref FindNumber(3);
            value *= 2;
            Console.Write("New Sequence:");
            Console.WriteLine(String.Join(" ", numbers));
            Console.ReadLine();
        }
        static int [] numbers = { 1,2,3,4,5};
        static ref int FindNumber(int target)
        {
            bool flag = true;
            ref int value = ref numbers[0];
            for (int ctr = 0; ctr< numbers.Length && flag == true; ctr++)
            {
                if (numbers[ctr] == target)
                {
                    value = ref numbers[ctr];
                    flag = false;
                }
            }
            return ref value;
        }
    }
}
