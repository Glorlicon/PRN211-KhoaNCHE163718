using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace DemoDataProviderFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //Get connection from appsettings.json
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
         
        }//End GetConnectionString
        static void ViewProducts()
        {
            DBProvideFactory factory = SqlClientFactory.Instance;
        }
    }
}
