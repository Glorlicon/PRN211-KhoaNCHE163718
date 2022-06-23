using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DemoStoredProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CategoryID = 1;
            var result = CountProductsByCategoryID(CategoryID);
            Console.WriteLine($"Number of products by CategoryID:{CategoryID}");
            Console.WriteLine($"-->OutputValue: {result.OutputValue}, ReturnValue: {result.ReturnValue}");
            CategoryID = 3;
            Console.WriteLine($"Number of products by CategoryID:{CategoryID}");
            result = CountProductsByCategoryID(CategoryID);
            Console.WriteLine($"-->OutputValue: {result.OutputValue}, ReturnValue: {result.ReturnValue}");
            Console.ReadLine();
        }

        static (int OutputValue, int ReturnValue) CountProductsByCategoryID(int CategoryID)
        {
            //Declare a tuple
            (int OutputValue, int ReturnValue) result;
            string ConnectionString = "Server=(local);uid=SE1611;pwd=123;database=MyStore";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            CountProductsUsingOutputValue();
            CountProductsUsingReturnValue();
            //Declare local functions
            void CountProductsUsingOutputValue()
            {
                command.CommandText = "spCountProductsUsingOutputValue";
                command.Parameters.AddWithValue("@CategoryID", CategoryID);
                //using output value
                command.Parameters.Add("@NumberOfProducts", System.Data.SqlDbType.Int).
                    Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                result.OutputValue = (int)command.Parameters["@NumberOfProducts"].Value;
            }//end function
            void CountProductsUsingReturnValue()
            {
                command.CommandText = "spCountProductsUsingReturnValue";
                //using return value
                command.Parameters["@NumberOfProducts"].Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                result.ReturnValue = (int)command.Parameters["@NumberOfProducts"].Value;
            }//end function
            connection.Close();
            return result;
        }//end ...
    }
}