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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            cbUsername = new ComboBox();
            txbPassword = new TextBox();
            chbRemember = new CheckBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            btnReg = new Button();
            lbDangNhap = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbUsername
            // 
            cbUsername.Font = new Font("Segoe UI", 10.8F);
            cbUsername.FormattingEnabled = true;
            cbUsername.Location = new Point(50, 110);
            cbUsername.Name = "cbUsername";
            cbUsername.Size = new Size(300, 33);
            cbUsername.TabIndex = 0;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 10.8F);
            txbPassword.Location = new Point(50, 210);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(300, 31);
            txbPassword.TabIndex = 1;
            // 
            // chbRemember
            // 
            chbRemember.AutoSize = true;
            chbRemember.Font = new Font("Segoe UI", 12F);
            chbRemember.Location = new Point(50, 243);
            chbRemember.Name = "chbRemember";
            chbRemember.Size = new Size(158, 32);
            chbRemember.TabIndex = 2;
            chbRemember.Text = "Nhớ mật khẩu";
            chbRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(50, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 79);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 179);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(225, 315);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(125, 50);
            btnReg.TabIndex = 6;
            btnReg.Text = "Đăng ký";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // lbDangNhap
            // 
            lbDangNhap.AutoSize = true;
            lbDangNhap.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDangNhap.ForeColor = Color.Black;
            lbDangNhap.Location = new Point(127, 26);
            lbDangNhap.Name = "lbDangNhap";
            lbDangNhap.Size = new Size(148, 35);
            lbDangNhap.TabIndex = 16;
            lbDangNhap.Text = "Đăng nhập";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnReg);
            panel1.Controls.Add(lbDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(chbRemember);
            panel1.Controls.Add(txbPassword);
            panel1.Controls.Add(cbUsername);
            panel1.Location = new Point(340, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 17;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 593);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lbDangNhap;
        private Panel panel1;
    }
}