using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMDIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }

        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem mnuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator separator = new ToolStripSeparator();    
            ToolStripMenuItem mmuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem menuWindow = new ToolStripMenuItem("&Window");

            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, menuWindow });
            mainMenu.MdiWindowListItem = menuWindow;

            menuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen, separator, mmuExit });

            mnuOpen.ShortcutKeys = (Keys) ((Keys.Control | Keys.O));
            mnuOpen.Click += new EventHandler(mnuOpen_Click);

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            frmChildForm ChildForm = new frmChildForm();
            ChildForm.Text = $"ChildForm {counter++:D2}";
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
