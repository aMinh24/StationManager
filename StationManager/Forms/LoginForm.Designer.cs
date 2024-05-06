namespace StationManager.Forms
{
    partial class LoginForm
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
            cbUsername = new ComboBox();
            txbPassword = new TextBox();
            chbRemember = new CheckBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            btnReg = new Button();
            SuspendLayout();
            // 
            // cbUsername
            // 
            cbUsername.FormattingEnabled = true;
            cbUsername.Location = new Point(191, 85);
            cbUsername.Name = "cbUsername";
            cbUsername.Size = new Size(151, 28);
            cbUsername.TabIndex = 0;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(191, 142);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(151, 27);
            txbPassword.TabIndex = 1;
            // 
            // chbRemember
            // 
            chbRemember.AutoSize = true;
            chbRemember.Location = new Point(191, 192);
            chbRemember.Name = "chbRemember";
            chbRemember.Size = new Size(124, 24);
            chbRemember.TabIndex = 2;
            chbRemember.Text = "Nhớ mật khẩu";
            chbRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(191, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 93);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 149);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(319, 246);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(94, 29);
            btnReg.TabIndex = 6;
            btnReg.Text = "Đăng ký";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(chbRemember);
            Controls.Add(txbPassword);
            Controls.Add(cbUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUsername;
        private TextBox txbPassword;
        private CheckBox chbRemember;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Button btnReg;
    }
}