using System;
using System.Threading;
using static System.Console;

namespace System.Threading.Thread_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";
            WriteLine($"ID of current thread: { primaryThread.ManagedThreadId}");
            WriteLine($"Thread Name: {primaryThread.Name}");
            WriteLine($"Has thread started?: {primaryThread.IsAlive}");
            WriteLine($"Priority Level: {primaryThread.Priority}");
            WriteLine($"Thread State: {primaryThread.ThreadState}");
            ReadLine();
        }
    }
}
