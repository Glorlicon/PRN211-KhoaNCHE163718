using System;
using System.IO;

namespace Directory_Class_Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get current directory
            string sourceDirectory = Directory.GetCurrentDirectory();
            try
            {
                //Get all files
                var txtFiles = Directory.EnumerateFiles(sourceDirectory,"*.*");
                foreach (string currentFile in txtFiles)
                {
                    Console.WriteLine(currentFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
