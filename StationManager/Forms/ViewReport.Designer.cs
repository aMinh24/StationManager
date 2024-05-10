namespace StationManager.Forms
{
    partial class ViewReport
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
            dtgvReport = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            txbId = new TextBox();
            txbTitle = new TextBox();
            txbContent = new TextBox();
            txbFile = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbEmployeeId = new TextBox();
            txbSent = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            button1 = new Button();
            lbReport = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvReport).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvReport
            // 
            dtgvReport.AllowUserToAddRows = false;
            dtgvReport.AllowUserToDeleteRows = false;
            dtgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvReport.BackgroundColor = Color.FromArgb(41, 128, 185);
            dtgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvReport.Location = new Point(25, 75);
            dtgvReport.Name = "dtgvReport";
            dtgvReport.ReadOnly = true;
            dtgvReport.RowHeadersWidth = 51;
            dtgvReport.Size = new Size(800, 525);
            dtgvReport.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8138962F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.1861038F));
            tableLayoutPanel1.Controls.Add(txbId, 1, 0);
            tableLayoutPanel1.Controls.Add(txbTitle, 1, 1);
            tableLayoutPanel1.Controls.Add(txbContent, 1, 2);
            tableLayoutPanel1.Controls.Add(txbFile, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txbEmployeeId, 1, 4);
            tableLayoutPanel1.Controls.Add(txbSent, 1, 5);
            tableLayoutPanel1.Location = new Point(850, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(406, 433);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txbId
            // 
            txbId.Dock = DockStyle.Top;
            txbId.Location = new Point(103, 3);
            txbId.Name = "txbId";
            txbId.ReadOnly = true;
            txbId.Size = new Size(300, 27);
            txbId.TabIndex = 0;
            // 
            // txbTitle
            // 
            txbTitle.Dock = DockStyle.Top;
            txbTitle.Location = new Point(103, 78);
            txbTitle.Name = "txbTitle";
            txbTitle.ReadOnly = true;
            txbTitle.Size = new Size(300, 27);
            txbTitle.TabIndex = 1;
            // 
            // txbContent
            // 
            txbContent.Dock = DockStyle.Top;
            txbContent.Location = new Point(103, 153);
            txbContent.Name = "txbContent";
            txbContent.ReadOnly = true;
            txbContent.Size = new Size(300, 27);
            txbContent.TabIndex = 2;
            // 
            // txbFile
            // 
            txbFile.Dock = DockStyle.Top;
            txbFile.Location = new Point(103, 228);
            txbFile.Name = "txbFile";
            txbFile.ReadOnly = true;
            txbFile.Size = new Size(300, 27);
            txbFile.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 150);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Nội dung";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 225);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 7;
            label4.Text = "File";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 300);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 8;
            label5.Text = "ID Nhân viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 375);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 9;
            label6.Text = "Ngày gửi";
            // 
            // txbEmployeeId
            // 
            txbEmployeeId.Dock = DockStyle.Top;
            txbEmployeeId.Location = new Point(103, 303);
            txbEmployeeId.Name = "txbEmployeeId";
            txbEmployeeId.ReadOnly = true;
            txbEmployeeId.Size = new Size(300, 27);
            txbEmployeeId.TabIndex = 11;
            // 
            // txbSent
            // 
            txbSent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSent.Location = new Point(103, 378);
            txbSent.Name = "txbSent";
            txbSent.ReadOnly = true;
            txbSent.Size = new Size(300, 27);
            txbSent.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(850, 550);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1131, 550);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 50);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(990, 550);
            button1.Name = "button1";
            button1.Size = new Size(125, 50);
            button1.TabIndex = 4;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbReport
            // 
            lbReport.AutoSize = true;
            lbReport.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbReport.ForeColor = Color.Black;
            lbReport.Location = new Point(309, 21);
            lbReport.Name = "lbReport";
            lbReport.Size = new Size(241, 35);
            lbReport.TabIndex = 17;
            lbReport.Text = "Danh sách báo cáo";
            // 
            // ViewReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(1282, 623);
            Controls.Add(lbReport);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtgvReport);
            Name = "ViewReport";
            Text = "ViewReport";
            ((System.ComponentModel.ISupportInitialize)dtgvReport).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvReport;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txbId;
        private TextBox txbTitle;
        private TextBox txbContent;
        private TextBox txbFile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbEmployeeId;
        private Button btnAdd;
        private Button btnEdit;
        private Button button1;
        private TextBox txbSent;
        private Label lbReport;
    }
}