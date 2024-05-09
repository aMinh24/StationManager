namespace StationManager.Forms
{
    partial class AddTask
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
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            txtNoiDung = new TextBox();
            txtTieuDe = new TextBox();
            txtMaNV = new TextBox();
            txtMaCV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbTaoTaiKhoan = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.Font = new Font("Segoe UI", 10.2F);
            dtpKetThuc.Location = new Point(50, 350);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(300, 30);
            dtpKetThuc.TabIndex = 30;
            // 
            // dtpBatDau
            // 
            dtpBatDau.Font = new Font("Segoe UI", 10.2F);
            dtpBatDau.Location = new Point(50, 250);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(300, 30);
            dtpBatDau.TabIndex = 29;
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = SystemColors.HighlightText;
            txtNoiDung.Font = new Font("Segoe UI", 10.2F);
            txtNoiDung.Location = new Point(50, 550);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(300, 30);
            txtNoiDung.TabIndex = 28;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // txtTieuDe
            // 
            txtTieuDe.BackColor = SystemColors.HighlightText;
            txtTieuDe.Font = new Font("Segoe UI", 10.2F);
            txtTieuDe.Location = new Point(50, 450);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(300, 30);
            txtTieuDe.TabIndex = 27;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10.2F);
            txtMaNV.Location = new Point(50, 150);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(300, 30);
            txtMaNV.TabIndex = 26;
            // 
            // txtMaCV
            // 
            txtMaCV.Font = new Font("Segoe UI", 10.2F);
            txtMaCV.Location = new Point(50, 50);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(300, 30);
            txtMaCV.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(50, 519);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 24;
            label6.Text = "Nội dung";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(50, 419);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 23;
            label5.Text = "Tiêu đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 319);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 22;
            label4.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 219);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 21;
            label3.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(49, 119);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 20;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 19;
            label1.Text = "Mã công việc";
            // 
            // button1
            // 
            button1.Location = new Point(100, 680);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 31;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(350, 680);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 32;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbTaoTaiKhoan
            // 
            lbTaoTaiKhoan.AutoSize = true;
            lbTaoTaiKhoan.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaoTaiKhoan.ForeColor = Color.Black;
            lbTaoTaiKhoan.Location = new Point(203, 9);
            lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
            lbTaoTaiKhoan.Size = new Size(207, 35);
            lbTaoTaiKhoan.TabIndex = 33;
            lbTaoTaiKhoan.Text = "Thêm công việc";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(dtpKetThuc);
            panel1.Controls.Add(dtpBatDau);
            panel1.Controls.Add(txtNoiDung);
            panel1.Controls.Add(txtTieuDe);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(txtMaCV);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(100, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 600);
            panel1.TabIndex = 34;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(582, 753);
            Controls.Add(panel1);
            Controls.Add(lbTaoTaiKhoan);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AddTask";
            Text = "AddTask";
            Load += AddTask_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private TextBox txtNoiDung;
        private TextBox txtTieuDe;
        private TextBox txtMaNV;
        private TextBox txtMaCV;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label lbTaoTaiKhoan;
        private Panel panel1;
    }
}