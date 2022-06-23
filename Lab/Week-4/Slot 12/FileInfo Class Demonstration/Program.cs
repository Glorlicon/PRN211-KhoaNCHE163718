using System;
using System.IO;

namespace FileInfo_Class_Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"MyFile.txt";
            Console.WriteLine("******Demo FileInfo Class");
            //Create a text file
            File.WriteAllText(fileName, "Hello World.");
            //Read file content
            Console.WriteLine("Read file:");
            string content = File.ReadAllText(fileName);
            Console.WriteLine(content);
            Console.WriteLine("File information:");
            //Get file information
            FileInfo testFile = new FileInfo(fileName);
            Console.WriteLine($"Name:{testFile.Name}");
            //Creation time
            Console.WriteLine($"Creation time: {testFile.CreationTime}");
            //Last write time
            Console.WriteLine($"Last Write Time: {testFile.LastWriteTime}");
            //Name of parent directory
            Console.WriteLine($"Directory Name: {testFile.DirectoryName}");
            Console.ReadLine();
        }
    }
}
