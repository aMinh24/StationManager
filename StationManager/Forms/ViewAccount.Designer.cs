using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace StationManager.Forms
{
    partial class ViewAccount
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgvAccount = new DataGridView();
            loginID = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            EmpID = new DataGridViewTextBoxColumn();
            lbPhanLoai = new Label();
            cbPhanLoai = new ComboBox();
            lbLoginID = new Label();
            tbLoginID = new TextBox();
            lbPassword = new Label();
            tbPassword = new TextBox();
            lbUsername = new Label();
            tbUsername = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbEmpID = new Label();
            tbEmpID = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAccount.BackgroundColor = Color.FromArgb(41, 128, 185);
            dtgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { loginID, Password, Username, Email, EmpID });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 227, 246);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvAccount.EnableHeadersVisualStyles = false;
            dtgvAccount.GridColor = SystemColors.ControlDark;
            dtgvAccount.Location = new Point(14, 16);
            dtgvAccount.Margin = new Padding(3, 4, 3, 4);
            dtgvAccount.MultiSelect = false;
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(861, 539);
            dtgvAccount.TabIndex = 0;
            // 
            // loginID
            // 
            loginID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loginID.DataPropertyName = "loginID";
            loginID.FillWeight = 10F;
            loginID.HeaderText = "Login ID";
            loginID.MinimumWidth = 6;
            loginID.Name = "loginID";
            loginID.ReadOnly = true;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "password";
            Password.FillWeight = 10F;
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.DataPropertyName = "username";
            Username.FillWeight = 10F;
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "email";
            Email.FillWeight = 15F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // EmpID
            // 
            EmpID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmpID.DataPropertyName = "empID";
            EmpID.FillWeight = 10F;
            EmpID.HeaderText = "Employee ID";
            EmpID.MinimumWidth = 6;
            EmpID.Name = "EmpID";
            EmpID.ReadOnly = true;
            // 
            // lbPhanLoai
            // 
            lbPhanLoai.AutoSize = true;
            lbPhanLoai.Location = new Point(894, 44);
            lbPhanLoai.Name = "lbPhanLoai";
            lbPhanLoai.Size = new Size(70, 20);
            lbPhanLoai.TabIndex = 1;
            lbPhanLoai.Text = "Phân loại";
            // 
            // cbPhanLoai
            // 
            cbPhanLoai.BackColor = Color.White;
            cbPhanLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhanLoai.FlatStyle = FlatStyle.Flat;
            cbPhanLoai.FormattingEnabled = true;
            cbPhanLoai.Items.AddRange(new object[] { "Khách hàng", "Nhân viên" });
            cbPhanLoai.Location = new Point(965, 40);
            cbPhanLoai.Margin = new Padding(3, 4, 3, 4);
            cbPhanLoai.Name = "cbPhanLoai";
            cbPhanLoai.Size = new Size(297, 28);
            cbPhanLoai.TabIndex = 2;
            cbPhanLoai.SelectedIndexChanged += cbPhanLoai_SelectedIndexChanged;
            // 
            // lbLoginID
            // 
            lbLoginID.AutoSize = true;
            lbLoginID.Location = new Point(894, 100);
            lbLoginID.Name = "lbLoginID";
            lbLoginID.Size = new Size(65, 20);
            lbLoginID.TabIndex = 3;
            lbLoginID.Text = "Login ID";
            // 
            // tbLoginID
            // 
            tbLoginID.BackColor = Color.White;
            tbLoginID.BorderStyle = BorderStyle.FixedSingle;
            tbLoginID.Location = new Point(894, 124);
            tbLoginID.Margin = new Padding(3, 4, 3, 4);
            tbLoginID.Name = "tbLoginID";
            tbLoginID.ReadOnly = true;
            tbLoginID.Size = new Size(167, 27);
            tbLoginID.TabIndex = 4;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(1095, 100);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(1095, 124);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(167, 27);
            tbPassword.TabIndex = 4;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(894, 179);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(894, 203);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(370, 27);
            tbUsername.TabIndex = 4;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(894, 255);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(894, 279);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(368, 27);
            tbEmail.TabIndex = 4;
            // 
            // lbEmpID
            // 
            lbEmpID.AutoSize = true;
            lbEmpID.Location = new Point(894, 332);
            lbEmpID.Name = "lbEmpID";
            lbEmpID.Size = new Size(94, 20);
            lbEmpID.TabIndex = 3;
            lbEmpID.Text = "Employee ID";
            // 
            // tbEmpID
            // 
            tbEmpID.BackColor = Color.White;
            tbEmpID.BorderStyle = BorderStyle.FixedSingle;
            tbEmpID.Location = new Point(894, 356);
            tbEmpID.Margin = new Padding(3, 4, 3, 4);
            tbEmpID.Name = "tbEmpID";
            tbEmpID.ReadOnly = true;
            tbEmpID.Size = new Size(368, 27);
            tbEmpID.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(71, 142, 204);
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(63, 126, 182);
            btnEdit.FlatStyle = FlatStyle.System;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1112, 423);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 50);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Cập nhật";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(97, 126, 140);
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(980, 505);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 50);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Tạo tài khoản nhân viên";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(240, 68, 56);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(63, 126, 182);
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(894, 423);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 50);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Vô hiệu hóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ViewAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(1278, 581);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tbEmpID);
            Controls.Add(lbEmpID);
            Controls.Add(tbEmail);
            Controls.Add(lbEmail);
            Controls.Add(tbUsername);
            Controls.Add(lbUsername);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbLoginID);
            Controls.Add(lbLoginID);
            Controls.Add(cbPhanLoai);
            Controls.Add(lbPhanLoai);
            Controls.Add(dtgvAccount);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewAccount";
            Text = "ViewAccount";
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvAccount;
        private Label lbPhanLoai;
        private ComboBox cbPhanLoai;
        private Label lbLoginID;
        private TextBox tbLoginID;
        private Label lbPassword;
        private TextBox tbPassword;
        private Label lbUsername;
        private TextBox tbUsername;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbEmpID;
        private TextBox tbEmpID;
        private DataGridViewTextBoxColumn loginID;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn EmpID;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
    }
}