using System;

namespace Processing_Command_Line_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            String msg = "***** Welcome to C#.net Programming *****";
            Console.WriteLine("{0}", msg);
            // Process any incoming agrs.
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg: {args[i]}");
            }
            Console.ReadLine();
        }
    }
}
