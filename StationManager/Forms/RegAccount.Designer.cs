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
            SuspendLayout();
            // 
            // lbLoginID
            // 
            lbLoginID.AutoSize = true;
            lbLoginID.Location = new Point(29, 91);
            lbLoginID.Name = "lbLoginID";
            lbLoginID.Size = new Size(51, 15);
            lbLoginID.TabIndex = 21;
            lbLoginID.Text = "Login ID";
            // 
            // tbLoginID
            // 
            tbLoginID.BackColor = Color.White;
            tbLoginID.BorderStyle = BorderStyle.FixedSingle;
            tbLoginID.Location = new Point(29, 109);
            tbLoginID.Name = "tbLoginID";
            tbLoginID.Size = new Size(146, 23);
            tbLoginID.TabIndex = 1;
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.BackColor = Color.FromArgb(138, 196, 75);
            btnTaoTaiKhoan.FlatAppearance.BorderColor = Color.FromArgb(78, 112, 43);
            btnTaoTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaoTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaoTaiKhoan.ForeColor = Color.White;
            btnTaoTaiKhoan.Location = new Point(29, 237);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(109, 36);
            btnTaoTaiKhoan.TabIndex = 5;
            btnTaoTaiKhoan.Text = "Đăng ký";
            btnTaoTaiKhoan.UseVisualStyleBackColor = false;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(224, 109);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(146, 23);
            tbPassword.TabIndex = 2;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(29, 155);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 19;
            lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(29, 173);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(146, 23);
            tbUsername.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(224, 155);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 18;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(224, 173);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(146, 23);
            tbEmail.TabIndex = 4;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(224, 91);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 20;
            lbPassword.Text = "Password";
            // 
            // lbTaoTaiKhoan
            // 
            lbTaoTaiKhoan.AutoSize = true;
            lbTaoTaiKhoan.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaoTaiKhoan.Location = new Point(29, 25);
            lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
            lbTaoTaiKhoan.Size = new Size(191, 28);
            lbTaoTaiKhoan.TabIndex = 27;
            lbTaoTaiKhoan.Text = "Đăng ký tài khoản";
            // 
            // RegAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 354);
            Controls.Add(btnTaoTaiKhoan);
            Controls.Add(lbTaoTaiKhoan);
            Controls.Add(tbEmail);
            Controls.Add(lbEmail);
            Controls.Add(tbUsername);
            Controls.Add(lbUsername);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbLoginID);
            Controls.Add(lbLoginID);
            Name = "RegAccount";
            Text = "RegAccount";
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
    }
}