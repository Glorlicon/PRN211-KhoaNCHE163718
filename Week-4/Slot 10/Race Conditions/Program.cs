using System;
using System.Threading;

namespace Race_Conditions
{
    public class Printer
    {
        private object threadLock = new object();
        public void PrintNumbers()
        {
            lock (threadLock)
                try
                {
                    Console.WriteLine("{0} is executing PrintNumbers()", Thread.CurrentThread.Name);
                    for (int i = 1; i <= 5; i++)
                    {
                        Random r = new Random();
                        Thread.Sleep(500 * r.Next(5));
                        Console.Write($"{i,3}{(i == 5 ? "" : ",")}");
                    }
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }
                finally
                {
                    //Monitor.Exit(threadLock);
                }
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("********Demo Synchronizing Thread********");
                Printer p = new Printer();
                Thread[] threads = new Thread[5];
                for (int i = 0; i < 5; i++)
                {
                    threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                    {
                        Name = $"Worker thread #{i + 1:D2}"
                    };
                }
                foreach (Thread t in threads)
                {
                    t.Start();
                }
                Console.ReadLine();
            }
        }
    }
