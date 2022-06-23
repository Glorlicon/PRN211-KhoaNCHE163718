using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConnectedLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgbData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic>();
            string ConnectionString = "Server=(local);uid=SE1611;pwd=123;database=MyStore";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("Select ProductName, UnitPrice From Products", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    products.Add(new
                    {
                        ProductName = reader.GetString("ProductName"),
                        UnitPrice = reader.GetDecimal("UnitPrice")
                    });
                }
                dgbData.DataSource = products;
            }
        }
    }
}
