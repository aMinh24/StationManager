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
            SuspendLayout();
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.Location = new Point(221, 212);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(527, 27);
            dtpKetThuc.TabIndex = 30;
            // 
            // dtpBatDau
            // 
            dtpBatDau.Location = new Point(221, 153);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(527, 27);
            dtpBatDau.TabIndex = 29;
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = SystemColors.HighlightText;
            txtNoiDung.Location = new Point(221, 327);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(527, 75);
            txtNoiDung.TabIndex = 28;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // txtTieuDe
            // 
            txtTieuDe.BackColor = SystemColors.HighlightText;
            txtTieuDe.Location = new Point(221, 262);
            txtTieuDe.Multiline = true;
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(527, 39);
            txtTieuDe.TabIndex = 27;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(221, 100);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(527, 27);
            txtMaNV.TabIndex = 26;
            // 
            // txtMaCV
            // 
            txtMaCV.Location = new Point(221, 44);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(527, 27);
            txtMaCV.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 336);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 24;
            label6.Text = "Nội dung";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 262);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 23;
            label5.Text = "Tiêu đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 212);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 22;
            label4.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 153);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 21;
            label3.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 99);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 20;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 19;
            label1.Text = "Mã công việc";
            // 
            // button1
            // 
            button1.Location = new Point(443, 435);
            button1.Name = "button1";
            button1.Size = new Size(139, 43);
            button1.TabIndex = 31;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(619, 435);
            button2.Name = "button2";
            button2.Size = new Size(129, 43);
            button2.TabIndex = 32;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpKetThuc);
            Controls.Add(dtpBatDau);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(txtMaNV);
            Controls.Add(txtMaCV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTask";
            Text = "AddTask";
            Load += AddTask_Load;
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
    }
}