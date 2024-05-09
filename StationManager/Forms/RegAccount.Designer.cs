namespace StationManager.Forms
{
    partial class RegAccount
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
            lbLoginID = new Label();
            tbLoginID = new TextBox();
            btnTaoTaiKhoan = new Button();
            tbPassword = new TextBox();
            lbUsername = new Label();
            tbUsername = new TextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbPassword = new Label();
            lbTaoTaiKhoan = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbLoginID
            // 
            lbLoginID.AutoSize = true;
            lbLoginID.Font = new Font("Segoe UI", 12F);
            lbLoginID.Location = new Point(50, 18);
            lbLoginID.Name = "lbLoginID";
            lbLoginID.Size = new Size(85, 28);
            lbLoginID.TabIndex = 21;
            lbLoginID.Text = "Login ID";
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
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.BackColor = Color.White;
            btnTaoTaiKhoan.FlatAppearance.BorderColor = Color.FromArgb(78, 112, 43);
            btnTaoTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaoTaiKhoan.ForeColor = Color.Black;
            btnTaoTaiKhoan.Location = new Point(225, 520);
            btnTaoTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(150, 50);
            btnTaoTaiKhoan.TabIndex = 5;
            btnTaoTaiKhoan.Text = "Đăng ký";
            btnTaoTaiKhoan.UseVisualStyleBackColor = false;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
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
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F);
            lbUsername.Location = new Point(50, 218);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 28);
            lbUsername.TabIndex = 19;
            lbUsername.Text = "Username";
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
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F);
            lbEmail.Location = new Point(50, 318);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(59, 28);
            lbEmail.TabIndex = 18;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.Location = new Point(50, 350);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(300, 34);
            tbEmail.TabIndex = 4;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F);
            lbPassword.Location = new Point(50, 118);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 28);
            lbPassword.TabIndex = 20;
            lbPassword.Text = "Password";
            // 
            // lbTaoTaiKhoan
            // 
            lbTaoTaiKhoan.AutoSize = true;
            lbTaoTaiKhoan.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaoTaiKhoan.Location = new Point(179, 25);
            lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
            lbTaoTaiKhoan.Size = new Size(238, 35);
            lbTaoTaiKhoan.TabIndex = 27;
            lbTaoTaiKhoan.Text = "Đăng ký tài khoản";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbLoginID);
            panel1.Controls.Add(lbLoginID);
            panel1.Location = new Point(100, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 410);
            panel1.TabIndex = 28;
            // 
            // RegAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(582, 603);
            Controls.Add(btnTaoTaiKhoan);
            Controls.Add(panel1);
            Controls.Add(lbTaoTaiKhoan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegAccount";
            Text = "RegAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLoginID;
        private TextBox tbLoginID;
        private Button btnTaoTaiKhoan;
        private TextBox tbPassword;
        private Label lbUsername;
        private TextBox tbUsername;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbPassword;
        private Label lbTaoTaiKhoan;
        private Panel panel1;
    }
}