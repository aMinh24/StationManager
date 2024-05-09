namespace StationManager.Forms
{
    partial class AddReport
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            txbTitle = new TextBox();
            txbContent = new TextBox();
            txbFile = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbEmployeeId = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            lbTitle = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(189, 195, 199);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1460667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.8539352F));
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(txbTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(txbContent, 1, 1);
            tableLayoutPanel1.Controls.Add(txbFile, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txbEmployeeId, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Location = new Point(100, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
<<<<<<< Updated upstream
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(376, 433);
=======
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7050362F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.4148674F));
            tableLayoutPanel1.Size = new Size(400, 400);
>>>>>>> Stashed changes
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
<<<<<<< Updated upstream
            button2.Location = new Point(279, 233);
=======
            button2.Location = new Point(303, 216);
>>>>>>> Stashed changes
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Tải file";
            button2.UseVisualStyleBackColor = true;
            // 
            // txbTitle
            // 
            txbTitle.Dock = DockStyle.Top;
            txbTitle.Location = new Point(95, 3);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(302, 27);
            txbTitle.TabIndex = 1;
            // 
            // txbContent
            // 
            txbContent.Dock = DockStyle.Top;
<<<<<<< Updated upstream
            txbContent.Location = new Point(148, 103);
=======
            txbContent.Location = new Point(95, 95);
>>>>>>> Stashed changes
            txbContent.Name = "txbContent";
            txbContent.Size = new Size(302, 27);
            txbContent.TabIndex = 2;
            // 
            // txbFile
            // 
            txbFile.Dock = DockStyle.Top;
<<<<<<< Updated upstream
            txbFile.Location = new Point(148, 203);
=======
            txbFile.Location = new Point(95, 187);
>>>>>>> Stashed changes
            txbFile.Name = "txbFile";
            txbFile.ReadOnly = true;
            txbFile.Size = new Size(302, 27);
            txbFile.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
<<<<<<< Updated upstream
            label3.Location = new Point(3, 100);
=======
            label3.Location = new Point(3, 92);
>>>>>>> Stashed changes
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Nội dung";
            // 
            // label4
            // 
            label4.AutoSize = true;
<<<<<<< Updated upstream
            label4.Location = new Point(3, 200);
=======
            label4.Location = new Point(3, 184);
>>>>>>> Stashed changes
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 7;
            label4.Text = "File";
            // 
            // txbEmployeeId
            // 
            txbEmployeeId.Dock = DockStyle.Top;
<<<<<<< Updated upstream
            txbEmployeeId.Location = new Point(148, 333);
=======
            txbEmployeeId.Location = new Point(95, 285);
>>>>>>> Stashed changes
            txbEmployeeId.Name = "txbEmployeeId";
            txbEmployeeId.Size = new Size(302, 27);
            txbEmployeeId.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
<<<<<<< Updated upstream
            label5.Location = new Point(3, 330);
=======
            label5.Location = new Point(3, 282);
>>>>>>> Stashed changes
            label5.Name = "label5";
            label5.Size = new Size(67, 40);
            label5.TabIndex = 12;
            label5.Text = "ID Nhân viên";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(78, 112, 43);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(234, 499);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
<<<<<<< Updated upstream
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(164, 9);
=======
            lbTitle.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Black;
            lbTitle.Location = new Point(221, 9);
>>>>>>> Stashed changes
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(163, 35);
            lbTitle.TabIndex = 18;
            lbTitle.Text = "Tạo báo cáo";
            // 
            // AddReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(582, 580);
            Controls.Add(lbTitle);
            Controls.Add(btnAdd);
            Controls.Add(tableLayoutPanel1);
            Name = "AddReport";
            Text = "AddReport";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txbTitle;
        private TextBox txbContent;
        private TextBox txbFile;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private TextBox txbEmployeeId;
        private Button btnAdd;
        private Label lbTitle;
    }
}