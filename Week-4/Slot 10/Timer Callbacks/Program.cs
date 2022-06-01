using System;
using System.Threading;

namespace Timer_Callbacks
{
    
    internal class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}. Pram is {1}",
            DateTime.Now.ToLongTimeString(), state.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****");
            TimerCallback timeCB = new TimerCallback(PrintTime);

            var _ = new Timer(
                timeCB,
                "Hello from Main",
                0,
                1000);
            Console.ReadLine();
        }
    }
}
