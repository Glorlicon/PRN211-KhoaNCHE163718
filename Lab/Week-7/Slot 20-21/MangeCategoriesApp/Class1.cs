using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangeCategoriesApp
{
    public record Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
    public class Class1
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=(local);uid=SE1611;pwd=123;database=MyStore";
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(ConnectionString);
            string SQL = "Select CategoryID, CategoryName From Categories";
            command = new SqlCommand(SQL, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryId = reader.GetInt32("CategoryID"),
                            CategoryName = reader.GetString("CategoryName")
                        });
                    }
                }
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return categories;
        }

        public void InsertCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Insert Categores values(@CategoryName)", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }
        }

        public void UpdateCategory (Category category)
        {
            connection = new SqlConnection (ConnectionString);
            String SQL = "Update Categories set CategoryName=@CategoryName where CategoryID=@CategoryID";
            command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryId);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally { connection.Close(); }
        }

        public void DeleteCategory (Category category)
        {
            connection = new SqlConnection(ConnectionString);
            string SQL = "Delete Categories Where CategoryID=@CategoryID";
            command = new SqlCommand (SQL, connection);
            command.Parameters.AddWithValue("CatergoryID", category.CategoryId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery ();
            }
            catch( Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }
        }
    }

    
}
