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

namespace DemoDisconnectedLayer
{
    public partial class Form1 : Form
    {
        DataSet dsMyStore = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsMyStore.Tables[1];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Server=(local);uid=SE1611;pwd=123;database=MyStore";
            string sql = "Select ProductID,ProductName,UnitsInStock From Products; Select * From Categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, ConnectionString);
                dataAdapter.Fill(dsMyStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data From Database");
            }
        }
    }
}
