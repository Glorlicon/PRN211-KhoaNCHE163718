using System;
using System.Threading;

namespace ParameterizedThreadStart_Delegate
{
    class MyParams
    {
        public int value01 { get; set; }
        public int value02 { get; set; }
    }
    class Program
    {
        static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void AddNumber(object data)
        {
            if (data is MyParams p)
            {
                Thread.Sleep(1000);
                Console.WriteLine("ID of thread in Add(): {0}",
                    Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine($"{p.value01} + {p.value02} = { p.value01 + p.value02}");
                waitHandle.Set();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ID of thread in Main(): {0}",
                Thread.CurrentThread.ManagedThreadId);
            MyParams p = new MyParams { value01 = 5, value02 = 15 };
            Thread t = new Thread(new ParameterizedThreadStart(AddNumber));
            t.IsBackground = true;
            t.Start(p);
            waitHandle.WaitOne();
            Console.WriteLine("Main Thread: Done.");
            Console.ReadLine();
        }
    }
}
