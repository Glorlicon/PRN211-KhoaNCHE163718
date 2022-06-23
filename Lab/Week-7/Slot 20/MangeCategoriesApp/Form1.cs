using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangeCategoriesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         Class1 manageCategories = new Class1();
        public void LoadCategories()
        {
            var categories = manageCategories.GetCategories();
            txtcategoryid.DataBindings.Clear();
            txtcategoryname.DataBindings.Clear();

            txtcategoryid.DataBindings.Add("Text", categories, "CategoryID");
            txtcategoryname.DataBindings.Add("Text", categories, "CategoryName");
            dgvCategory.DataSource = categories;
        }

        private void txtcategoryid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcategoryname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryName = txtcategoryname.Text };
                manageCategories.InsertCategory(category);
                LoadCategories();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Insert Category");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryId = int.Parse(txtcategoryid.Text),
                    CategoryName = txtcategoryname.Text
                };
                manageCategories.UpdateCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Update Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryId = int.Parse(txtcategoryid.Text)
                };
                manageCategories.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
