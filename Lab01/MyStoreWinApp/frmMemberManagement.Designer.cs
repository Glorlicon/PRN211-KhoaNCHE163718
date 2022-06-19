
namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdMemberName = new System.Windows.Forms.RadioButton();
            this.rdMemberID = new System.Windows.Forms.RadioButton();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdCountry = new System.Windows.Forms.RadioButton();
            this.rdCity = new System.Windows.Forms.RadioButton();
            this.rdRole = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.grSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(18, 30);
            this.lbMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(127, 25);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(194, 27);
            this.txtMemberID.TabIndex = 1;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(18, 66);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(109, 20);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(127, 62);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(194, 27);
            this.txtMemberName.TabIndex = 1;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(370, 30);
            this.lbCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(449, 25);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(194, 27);
            this.txtCity.TabIndex = 1;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(370, 66);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 0;
            this.lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(449, 62);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(194, 27);
            this.txtCountry.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(18, 104);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(127, 99);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(370, 104);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(449, 99);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(194, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(127, 142);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 25);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(449, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(291, 142);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 25);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(22, 300);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 62;
            this.dgvMemberList.RowTemplate.Height = 33;
            this.dgvMemberList.Size = new System.Drawing.Size(621, 158);
            this.dgvMemberList.TabIndex = 3;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            this.dgvMemberList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMemberList_CellFormatting);
            this.dgvMemberList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_RowEnter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(303, 462);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.rdRole);
            this.grSearch.Controls.Add(this.rdCity);
            this.grSearch.Controls.Add(this.rdCountry);
            this.grSearch.Controls.Add(this.rdEmail);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.txtSearch);
            this.grSearch.Controls.Add(this.rdMemberName);
            this.grSearch.Controls.Add(this.rdMemberID);
            this.grSearch.Location = new System.Drawing.Point(84, 180);
            this.grSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grSearch.Size = new System.Drawing.Size(480, 116);
            this.grSearch.TabIndex = 4;
            this.grSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(25, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // rdMemberName
            // 
            this.rdMemberName.AutoSize = true;
            this.rdMemberName.Location = new System.Drawing.Point(181, 62);
            this.rdMemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdMemberName.Name = "rdMemberName";
            this.rdMemberName.Size = new System.Drawing.Size(130, 24);
            this.rdMemberName.TabIndex = 0;
            this.rdMemberName.Text = "Member Name";
            this.rdMemberName.UseVisualStyleBackColor = true;
            this.rdMemberName.CheckedChanged += new System.EventHandler(this.rdMemberName_CheckedChanged);
            // 
            // rdMemberID
            // 
            this.rdMemberID.AutoSize = true;
            this.rdMemberID.Checked = true;
            this.rdMemberID.Location = new System.Drawing.Point(25, 62);
            this.rdMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdMemberID.Name = "rdMemberID";
            this.rdMemberID.Size = new System.Drawing.Size(101, 24);
            this.rdMemberID.TabIndex = 0;
            this.rdMemberID.TabStop = true;
            this.rdMemberID.Text = "MemberID";
            this.rdMemberID.UseVisualStyleBackColor = true;
            this.rdMemberID.CheckedChanged += new System.EventHandler(this.rdMemberID_CheckedChanged);
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.Location = new System.Drawing.Point(354, 62);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(67, 24);
            this.rdEmail.TabIndex = 3;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = true;
            this.rdEmail.CheckedChanged += new System.EventHandler(this.rdEmail_CheckedChanged);
            // 
            // rdCountry
            // 
            this.rdCountry.AutoSize = true;
            this.rdCountry.Location = new System.Drawing.Point(354, 87);
            this.rdCountry.Name = "rdCountry";
            this.rdCountry.Size = new System.Drawing.Size(81, 24);
            this.rdCountry.TabIndex = 4;
            this.rdCountry.TabStop = true;
            this.rdCountry.Text = "Country";
            this.rdCountry.UseVisualStyleBackColor = true;
            this.rdCountry.CheckedChanged += new System.EventHandler(this.rdCountry_CheckedChanged);
            // 
            // rdCity
            // 
            this.rdCity.AutoSize = true;
            this.rdCity.Location = new System.Drawing.Point(181, 87);
            this.rdCity.Name = "rdCity";
            this.rdCity.Size = new System.Drawing.Size(55, 24);
            this.rdCity.TabIndex = 5;
            this.rdCity.TabStop = true;
            this.rdCity.Text = "City";
            this.rdCity.UseVisualStyleBackColor = true;
            this.rdCity.CheckedChanged += new System.EventHandler(this.rdCity_CheckedChanged);
            // 
            // rdRole
            // 
            this.rdRole.AutoSize = true;
            this.rdRole.Location = new System.Drawing.Point(25, 87);
            this.rdRole.Name = "rdRole";
            this.rdRole.Size = new System.Drawing.Size(60, 24);
            this.rdRole.TabIndex = 6;
            this.rdRole.TabStop = true;
            this.rdRole.Text = "Role";
            this.rdRole.UseVisualStyleBackColor = true;
            this.rdRole.CheckedChanged += new System.EventHandler(this.rdRole_CheckedChanged);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 497);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemberID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            this.Shown += new System.EventHandler(this.frmMemberManagement_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdMemberName;
        private System.Windows.Forms.RadioButton rdMemberID;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdRole;
        private System.Windows.Forms.RadioButton rdCity;
        private System.Windows.Forms.RadioButton rdCountry;
    }
}