namespace StationManager.Forms
{
    partial class AddAccount
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
            tbEmpID = new TextBox();
            lbEmpID = new Label();
            tbEmail = new TextBox();
            lbEmail = new Label();
            tbUsername = new TextBox();
            lbUsername = new Label();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbLoginID = new TextBox();
            lbLoginID = new Label();
            lbTaoTaiKhoan = new Label();
            btnTaoTaiKhoan = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbEmpID
            // 
            tbEmpID.BackColor = Color.White;
            tbEmpID.BorderStyle = BorderStyle.FixedSingle;
            tbEmpID.Font = new Font("Segoe UI", 12F);
            tbEmpID.Location = new Point(50, 350);
            tbEmpID.Margin = new Padding(3, 4, 3, 4);
            tbEmpID.Name = "tbEmpID";
            tbEmpID.Size = new Size(300, 34);
            tbEmpID.TabIndex = 5;
            // 
            // lbEmpID
            // 
            lbEmpID.AutoSize = true;
            lbEmpID.Font = new Font("Segoe UI", 12F);
            lbEmpID.ForeColor = Color.Black;
            lbEmpID.Location = new Point(50, 318);
            lbEmpID.Name = "lbEmpID";
            lbEmpID.Size = new Size(122, 28);
            lbEmpID.TabIndex = 5;
            lbEmpID.Text = "Employee ID";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.Location = new Point(50, 450);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(300, 34);
            tbEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(50, 418);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(59, 28);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(50, 250);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(300, 34);
            tbUsername.TabIndex = 3;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F);
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(50, 218);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 28);
            lbUsername.TabIndex = 7;
            lbUsername.Text = "Username";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(50, 150);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(300, 34);
            tbPassword.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F);
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(50, 118);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 28);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // tbLoginID
            // 
            tbLoginID.BackColor = Color.White;
            tbLoginID.BorderStyle = BorderStyle.FixedSingle;
            tbLoginID.Font = new Font("Segoe UI", 12F);
            tbLoginID.Location = new Point(50, 50);
            tbLoginID.Margin = new Padding(3, 4, 3, 4);
            tbLoginID.Name = "tbLoginID";
            tbLoginID.Size = new Size(300, 34);
            tbLoginID.TabIndex = 1;
            // 
            // lbLoginID
            // 
            lbLoginID.AutoSize = true;
            lbLoginID.Font = new Font("Segoe UI", 12F);
            lbLoginID.ForeColor = Color.Black;
            lbLoginID.Location = new Point(50, 18);
            lbLoginID.Name = "lbLoginID";
            lbLoginID.Size = new Size(85, 28);
            lbLoginID.TabIndex = 9;
            lbLoginID.Text = "Login ID";
            lbLoginID.Click += lbLoginID_Click;
            // 
            // lbTaoTaiKhoan
            // 
            lbTaoTaiKhoan.AutoSize = true;
            lbTaoTaiKhoan.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaoTaiKhoan.ForeColor = Color.Black;
            lbTaoTaiKhoan.Location = new Point(145, 25);
            lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
            lbTaoTaiKhoan.Size = new Size(311, 35);
            lbTaoTaiKhoan.TabIndex = 15;
            lbTaoTaiKhoan.Text = "Tạo tài khoản nhân viên";
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.BackColor = Color.White;
            btnTaoTaiKhoan.FlatAppearance.BorderColor = Color.FromArgb(78, 112, 43);
            btnTaoTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaoTaiKhoan.ForeColor = Color.Black;
            btnTaoTaiKhoan.Location = new Point(225, 605);
            btnTaoTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(150, 50);
            btnTaoTaiKhoan.TabIndex = 16;
            btnTaoTaiKhoan.Text = "Tạo tài khoản";
            btnTaoTaiKhoan.UseVisualStyleBackColor = false;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbEmpID);
            panel1.Controls.Add(lbEmpID);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbLoginID);
            panel1.Controls.Add(lbLoginID);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(100, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 510);
            panel1.TabIndex = 17;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(582, 678);
            Controls.Add(panel1);
            Controls.Add(btnTaoTaiKhoan);
            Controls.Add(lbTaoTaiKhoan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAccount";
            Text = "AddAccount";
            Load += AddAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmpID;
        private Label lbEmpID;
        private TextBox tbEmail;
        private Label lbEmail;
        private TextBox tbUsername;
        private Label lbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private TextBox tbLoginID;
        private Label lbLoginID;
        private Label lbTaoTaiKhoan;
        private Button btnTaoTaiKhoan;
        private Panel panel1;
    }
}