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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.56383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.43617F));
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(txbTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(txbContent, 1, 1);
            tableLayoutPanel1.Controls.Add(txbFile, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txbEmployeeId, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Location = new Point(75, 48);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(329, 325);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(244, 174);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 4;
            button2.Text = "Tải file";
            button2.UseVisualStyleBackColor = true;
            // 
            // txbTitle
            // 
            txbTitle.Dock = DockStyle.Top;
            txbTitle.Location = new Point(129, 2);
            txbTitle.Margin = new Padding(3, 2, 3, 2);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(197, 23);
            txbTitle.TabIndex = 1;
            // 
            // txbContent
            // 
            txbContent.Dock = DockStyle.Top;
            txbContent.Location = new Point(129, 77);
            txbContent.Margin = new Padding(3, 2, 3, 2);
            txbContent.Name = "txbContent";
            txbContent.Size = new Size(197, 23);
            txbContent.TabIndex = 2;
            // 
            // txbFile
            // 
            txbFile.Dock = DockStyle.Top;
            txbFile.Location = new Point(129, 152);
            txbFile.Margin = new Padding(3, 2, 3, 2);
            txbFile.Name = "txbFile";
            txbFile.ReadOnly = true;
            txbFile.Size = new Size(197, 23);
            txbFile.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Nội dung";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 150);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 7;
            label4.Text = "File";
            // 
            // txbEmployeeId
            // 
            txbEmployeeId.Dock = DockStyle.Top;
            txbEmployeeId.Location = new Point(129, 249);
            txbEmployeeId.Margin = new Padding(3, 2, 3, 2);
            txbEmployeeId.Name = "txbEmployeeId";
            txbEmployeeId.Size = new Size(197, 23);
            txbEmployeeId.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 247);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 12;
            label5.Text = "ID Nhân viên";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(437, 351);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Xác nhận";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F);
            lbTitle.Location = new Point(144, 7);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(189, 37);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "Thêm Báo Cáo";
            // 
            // AddReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 382);
            Controls.Add(lbTitle);
            Controls.Add(btnAdd);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnAdd;
        private Button button2;
        private Label label5;
        private TextBox txbEmployeeId;
        private Label lbTitle;
    }
}