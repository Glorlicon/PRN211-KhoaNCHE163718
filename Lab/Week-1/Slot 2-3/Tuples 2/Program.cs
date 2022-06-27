using System;

namespace Tuples_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var (sum, count) = MyMethod(numbers);
            Console.WriteLine($"Sum: {sum}, Count: {count}");
            Console.ReadLine();
        }
        static (int sum, int count) MyMethod(int[] value)
        {
            var r = (sum:0, count:0);
            for (int i = 0; i < value.Length; i++)
            {
                if (IsEvenNumber(value[i]))
                {
                    r.sum += value[i];
                    r.count++;
                }
            }
            return r;
            bool IsEvenNumber(int n)
            {
                return n % 2 == 0;
            }
        }

    }
}
