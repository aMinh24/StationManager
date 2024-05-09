namespace StationManager.Forms
{
    partial class ViewTask
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
            dtgvCongViec = new DataGridView();
            btnThem = new Button();
            button2 = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaCV = new TextBox();
            txtMaNV = new TextBox();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            dtpBatDau = new DateTimePicker();
            dtpKetThuc = new DateTimePicker();
            lbTask = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvCongViec).BeginInit();
            SuspendLayout();
            // 
            // dtgvCongViec
            // 
            dtgvCongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCongViec.BackgroundColor = Color.FromArgb(41, 128, 185);
            dtgvCongViec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCongViec.Location = new Point(25, 75);
            dtgvCongViec.Name = "dtgvCongViec";
            dtgvCongViec.ReadOnly = true;
            dtgvCongViec.RowHeadersWidth = 51;
            dtgvCongViec.Size = new Size(800, 525);
            dtgvCongViec.TabIndex = 0;
            dtgvCongViec.CellContentClick += dtgvCongViec_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(850, 495);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(850, 560);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 2;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1050, 495);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1050, 560);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(850, 75);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 5;
            label1.Text = "Mã công việc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1050, 75);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 6;
            label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(850, 159);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 7;
            label3.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(850, 242);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 8;
            label4.Text = "Thời gian kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(850, 327);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 9;
            label5.Text = "Tiêu đề";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(850, 408);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 10;
            label6.Text = "Nội dung";
            // 
            // txtMaCV
            // 
            txtMaCV.Font = new Font("Segoe UI", 10.8F);
            txtMaCV.Location = new Point(850, 103);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(150, 31);
            txtMaCV.TabIndex = 11;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10.8F);
            txtMaNV.Location = new Point(1051, 103);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(150, 31);
            txtMaNV.TabIndex = 12;
            // 
            // txtTieuDe
            // 
            txtTieuDe.BackColor = SystemColors.HighlightText;
            txtTieuDe.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTieuDe.Location = new Point(850, 355);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(350, 31);
            txtTieuDe.TabIndex = 15;
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = SystemColors.HighlightText;
            txtNoiDung.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiDung.Location = new Point(850, 436);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(350, 31);
            txtNoiDung.TabIndex = 16;
            // 
            // dtpBatDau
            // 
            dtpBatDau.Font = new Font("Segoe UI", 10.8F);
            dtpBatDau.Location = new Point(850, 187);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(351, 31);
            dtpBatDau.TabIndex = 17;
            dtpBatDau.ValueChanged += dtpBatDau_ValueChanged;
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.Font = new Font("Segoe UI", 10.8F);
            dtpKetThuc.Location = new Point(850, 270);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(351, 31);
            dtpKetThuc.TabIndex = 18;
            // 
            // lbTask
            // 
            lbTask.AutoSize = true;
            lbTask.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTask.ForeColor = Color.Black;
            lbTask.Location = new Point(300, 22);
            lbTask.Name = "lbTask";
            lbTask.Size = new Size(262, 35);
            lbTask.TabIndex = 19;
            lbTask.Text = "Danh sách công việc";
            // 
            // ViewTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(1222, 623);
            Controls.Add(lbTask);
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
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(button2);
            Controls.Add(btnThem);
            Controls.Add(dtgvCongViec);
            Name = "ViewTask";
            Text = "ViewTask";
            Load += ViewTask_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCongViec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCongViec;
        private Button btnThem;
        private Button button2;
        private Button btnXoa;
        private Button btnLuu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaCV;
        private TextBox txtMaNV;
        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private DateTimePicker dtpBatDau;
        private DateTimePicker dtpKetThuc;
        private Label lbTask;
    }
}