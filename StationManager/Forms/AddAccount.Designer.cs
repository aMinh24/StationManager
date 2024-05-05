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
            SuspendLayout();
            // 
            // tbEmpID
            // 
            tbEmpID.BackColor = Color.White;
            tbEmpID.BorderStyle = BorderStyle.FixedSingle;
            tbEmpID.Location = new Point(12, 226);
            tbEmpID.Name = "tbEmpID";
            tbEmpID.Size = new Size(146, 23);
            tbEmpID.TabIndex = 10;
            // 
            // lbEmpID
            // 
            lbEmpID.AutoSize = true;
            lbEmpID.Location = new Point(12, 208);
            lbEmpID.Name = "lbEmpID";
            lbEmpID.Size = new Size(73, 15);
            lbEmpID.TabIndex = 5;
            lbEmpID.Text = "Employee ID";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(207, 166);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(146, 23);
            tbEmail.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(207, 148);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(12, 166);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(146, 23);
            tbUsername.TabIndex = 12;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(12, 148);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 7;
            lbUsername.Text = "Username";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(207, 102);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(146, 23);
            tbPassword.TabIndex = 13;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(207, 84);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // tbLoginID
            // 
            tbLoginID.BackColor = Color.White;
            tbLoginID.BorderStyle = BorderStyle.FixedSingle;
            tbLoginID.Location = new Point(12, 102);
            tbLoginID.Name = "tbLoginID";
            tbLoginID.Size = new Size(146, 23);
            tbLoginID.TabIndex = 14;
            // 
            // lbLoginID
            // 
            lbLoginID.AutoSize = true;
            lbLoginID.Location = new Point(12, 84);
            lbLoginID.Name = "lbLoginID";
            lbLoginID.Size = new Size(51, 15);
            lbLoginID.TabIndex = 9;
            lbLoginID.Text = "Login ID";
            // 
            // lbTaoTaiKhoan
            // 
            lbTaoTaiKhoan.AutoSize = true;
            lbTaoTaiKhoan.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaoTaiKhoan.Location = new Point(12, 18);
            lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
            lbTaoTaiKhoan.Size = new Size(250, 28);
            lbTaoTaiKhoan.TabIndex = 15;
            lbTaoTaiKhoan.Text = "Tạo tài khoản nhân viên";
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.Location = new Point(21, 292);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(109, 23);
            btnTaoTaiKhoan.TabIndex = 16;
            btnTaoTaiKhoan.Text = "Tạo tài khoản";
            btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 354);
            Controls.Add(btnTaoTaiKhoan);
            Controls.Add(lbTaoTaiKhoan);
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
            Name = "AddAccount";
            Text = "AddAccount";
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
    }
}