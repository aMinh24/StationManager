namespace StationManager.Forms
{
    partial class AddRequest
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRequest));
            lbRequest = new Label();
            btnSendRequest = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            txbContent = new TextBox();
            txbTitle = new TextBox();
            panel1 = new Panel();
            dtgvRequest = new DataGridView();
            btnShow = new Button();
            dtpTimeEnd = new DateTimePicker();
            dtpTimeStart = new DateTimePicker();
            label1 = new Label();
            ttError = new ToolTip(components);
            btnErrorTitle = new Button();
            btnErrorContent = new Button();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRequest).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbRequest
            // 
            lbRequest.AutoSize = true;
            lbRequest.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbRequest.ForeColor = Color.Black;
            lbRequest.Location = new Point(143, 21);
            lbRequest.Name = "lbRequest";
            lbRequest.Size = new Size(262, 38);
            lbRequest.TabIndex = 1;
            lbRequest.Text = "Gửi yêu cầu hỗ trợ";
            // 
            // btnSendRequest
            // 
            btnSendRequest.BackColor = Color.FromArgb(46, 204, 113);
            btnSendRequest.FlatStyle = FlatStyle.System;
            btnSendRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendRequest.ForeColor = SystemColors.ButtonHighlight;
            btnSendRequest.Location = new Point(212, 195);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(94, 46);
            btnSendRequest.TabIndex = 2;
            btnSendRequest.Text = "Gửi";
            btnSendRequest.UseVisualStyleBackColor = false;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4697514F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.53025F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txbContent, 1, 1);
            tableLayoutPanel1.Controls.Add(txbTitle, 1, 0);
            tableLayoutPanel1.Location = new Point(39, 78);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.0612259F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.9387741F));
            tableLayoutPanel1.Size = new Size(393, 98);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 52);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "Nội dung";
            // 
            // txbContent
            // 
            txbContent.Location = new Point(114, 55);
            txbContent.Name = "txbContent";
            txbContent.Size = new Size(276, 27);
            txbContent.TabIndex = 3;
            txbContent.TextChanged += txbContent_TextChanged;
            // 
            // txbTitle
            // 
            txbTitle.Location = new Point(114, 3);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(276, 27);
            txbTitle.TabIndex = 2;
            txbTitle.TextChanged += txbTitle_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvRequest);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(dtpTimeEnd);
            panel1.Controls.Add(dtpTimeStart);
            panel1.Location = new Point(15, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 450);
            panel1.TabIndex = 4;
            // 
            // dtgvRequest
            // 
            dtgvRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRequest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvRequest.BackgroundColor = Color.FromArgb(41, 128, 185);
            dtgvRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRequest.Location = new Point(0, 45);
            dtgvRequest.Name = "dtgvRequest";
            dtgvRequest.RowHeadersWidth = 51;
            dtgvRequest.Size = new Size(620, 405);
            dtgvRequest.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(46, 204, 113);
            btnShow.FlatStyle = FlatStyle.System;
            btnShow.ForeColor = SystemColors.ButtonFace;
            btnShow.Location = new Point(269, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 36);
            btnShow.TabIndex = 2;
            btnShow.Text = "Xem";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dtpTimeEnd
            // 
            dtpTimeEnd.Format = DateTimePickerFormat.Short;
            dtpTimeEnd.Location = new Point(417, 3);
            dtpTimeEnd.Name = "dtpTimeEnd";
            dtpTimeEnd.Size = new Size(203, 27);
            dtpTimeEnd.TabIndex = 1;
            // 
            // dtpTimeStart
            // 
            dtpTimeStart.Format = DateTimePickerFormat.Short;
            dtpTimeStart.Location = new Point(0, 3);
            dtpTimeStart.Name = "dtpTimeStart";
            dtpTimeStart.Size = new Size(216, 27);
            dtpTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 21);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 5;
            label1.Text = "Yêu cầu đã gửi";
            // 
            // btnErrorTitle
            // 
            btnErrorTitle.Image = (Image)resources.GetObject("btnErrorTitle.Image");
            btnErrorTitle.Location = new Point(438, 80);
            btnErrorTitle.Name = "btnErrorTitle";
            btnErrorTitle.Size = new Size(33, 29);
            btnErrorTitle.TabIndex = 6;
            btnErrorTitle.UseVisualStyleBackColor = true;
            btnErrorTitle.Click += btnErrorTitle_Click;
            // 
            // btnErrorContent
            // 
            btnErrorContent.Image = (Image)resources.GetObject("btnErrorContent.Image");
            btnErrorContent.Location = new Point(438, 132);
            btnErrorContent.Name = "btnErrorContent";
            btnErrorContent.Size = new Size(33, 29);
            btnErrorContent.TabIndex = 7;
            btnErrorContent.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(531, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 556);
            panel2.TabIndex = 8;
            // 
            // AddRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(1182, 553);
            Controls.Add(panel2);
            Controls.Add(btnErrorContent);
            Controls.Add(btnErrorTitle);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSendRequest);
            Controls.Add(lbRequest);
            Name = "AddRequest";
            Text = "AddRequest";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRequest).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbRequest;
        private Button btnSendRequest;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private TextBox txbContent;
        private Label label3;
        private TextBox txbTitle;
        private DataGridView dtgvRequest;
        private Button btnShow;
        private DateTimePicker dtpTimeEnd;
        private DateTimePicker dtpTimeStart;
        private ToolTip ttError;
        private Button btnErrorTitle;
        private Button btnErrorContent;
        private Panel panel2;
    }
}