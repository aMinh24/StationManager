namespace StationManager.Forms
{
    partial class ViewRequest
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
            dtgvShow = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCountToday = new Button();
            btnToday = new Button();
            btnNoView = new Button();
            btnCountNoView = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            txbStatus = new TextBox();
            txbTimeSent = new TextBox();
            txbContent = new TextBox();
            txbTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbSendCode = new TextBox();
            btnConfirm = new Button();
            btnShowAll = new Button();
            btnErrorTime = new Button();
            lbRequest = new Label();
            ttError = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dtgvShow).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvShow
            // 
            dtgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvShow.BackgroundColor = Color.FromArgb(41, 128, 185);
            dtgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShow.Location = new Point(25, 150);
            dtgvShow.Name = "dtgvShow";
            dtgvShow.ReadOnly = true;
            dtgvShow.RowHeadersWidth = 51;
            dtgvShow.Size = new Size(800, 450);
            dtgvShow.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.81884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.18116F));
            tableLayoutPanel1.Controls.Add(btnCountToday, 1, 1);
            tableLayoutPanel1.Controls.Add(btnToday, 1, 0);
            tableLayoutPanel1.Controls.Add(btnNoView, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCountNoView, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpEnd, 2, 1);
            tableLayoutPanel1.Controls.Add(dtpStart, 2, 0);
            tableLayoutPanel1.Location = new Point(25, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6666679F));
            tableLayoutPanel1.Size = new Size(644, 70);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnCountToday
            // 
            btnCountToday.Dock = DockStyle.Fill;
            btnCountToday.Location = new Point(200, 37);
            btnCountToday.Name = "btnCountToday";
            btnCountToday.Size = new Size(190, 30);
            btnCountToday.TabIndex = 3;
            btnCountToday.Text = "0";
            btnCountToday.UseVisualStyleBackColor = true;
            btnCountToday.Click += btnCountToday_Click;
            // 
            // btnToday
            // 
            btnToday.BackColor = Color.IndianRed;
            btnToday.Dock = DockStyle.Fill;
            btnToday.ForeColor = SystemColors.ButtonFace;
            btnToday.Location = new Point(200, 3);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(190, 28);
            btnToday.TabIndex = 1;
            btnToday.Text = "Yêu cầu hôm nay";
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnNoView
            // 
            btnNoView.BackColor = Color.IndianRed;
            btnNoView.Dock = DockStyle.Fill;
            btnNoView.ForeColor = SystemColors.ButtonFace;
            btnNoView.Location = new Point(3, 3);
            btnNoView.Name = "btnNoView";
            btnNoView.Size = new Size(191, 28);
            btnNoView.TabIndex = 0;
            btnNoView.Text = "Yêu cầu chưa xem";
            btnNoView.UseVisualStyleBackColor = false;
            btnNoView.Click += btnNoView_Click;
            // 
            // btnCountNoView
            // 
            btnCountNoView.Dock = DockStyle.Fill;
            btnCountNoView.Location = new Point(3, 37);
            btnCountNoView.Name = "btnCountNoView";
            btnCountNoView.Size = new Size(191, 30);
            btnCountNoView.TabIndex = 2;
            btnCountNoView.Text = "0";
            btnCountNoView.UseVisualStyleBackColor = true;
            btnCountNoView.Click += btnCountNoView_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(396, 37);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(245, 27);
            dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(396, 3);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(245, 27);
            dtpStart.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8066158F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.19338F));
            tableLayoutPanel2.Controls.Add(txbStatus, 1, 4);
            tableLayoutPanel2.Controls.Add(txbTimeSent, 1, 3);
            tableLayoutPanel2.Controls.Add(txbContent, 1, 2);
            tableLayoutPanel2.Controls.Add(txbTitle, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(txbSendCode, 1, 0);
            tableLayoutPanel2.Location = new Point(850, 150);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.1428566F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.8571434F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Size = new Size(400, 375);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // txbStatus
            // 
            txbStatus.Dock = DockStyle.Top;
            txbStatus.Location = new Point(130, 307);
            txbStatus.Name = "txbStatus";
            txbStatus.ReadOnly = true;
            txbStatus.Size = new Size(267, 27);
            txbStatus.TabIndex = 9;
            // 
            // txbTimeSent
            // 
            txbTimeSent.Dock = DockStyle.Top;
            txbTimeSent.Location = new Point(130, 240);
            txbTimeSent.Name = "txbTimeSent";
            txbTimeSent.ReadOnly = true;
            txbTimeSent.Size = new Size(267, 27);
            txbTimeSent.TabIndex = 8;
            // 
            // txbContent
            // 
            txbContent.Dock = DockStyle.Top;
            txbContent.Location = new Point(130, 155);
            txbContent.Name = "txbContent";
            txbContent.ReadOnly = true;
            txbContent.Size = new Size(267, 27);
            txbContent.TabIndex = 7;
            // 
            // txbTitle
            // 
            txbTitle.Dock = DockStyle.Top;
            txbTitle.Location = new Point(130, 75);
            txbTitle.Name = "txbTitle";
            txbTitle.ReadOnly = true;
            txbTitle.Size = new Size(267, 27);
            txbTitle.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 72);
            label1.TabIndex = 0;
            label1.Text = "Mã yêu cầu";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(121, 80);
            label2.TabIndex = 1;
            label2.Text = "Tiêu đề";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 152);
            label3.Name = "label3";
            label3.Size = new Size(121, 85);
            label3.TabIndex = 2;
            label3.Text = "Nội dung";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 237);
            label4.Name = "label4";
            label4.Size = new Size(121, 67);
            label4.TabIndex = 3;
            label4.Text = "Thời gian gửi";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 304);
            label5.Name = "label5";
            label5.Size = new Size(121, 71);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txbSendCode
            // 
            txbSendCode.Dock = DockStyle.Top;
            txbSendCode.Location = new Point(130, 3);
            txbSendCode.Name = "txbSendCode";
            txbSendCode.ReadOnly = true;
            txbSendCode.Size = new Size(267, 27);
            txbSendCode.TabIndex = 5;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.White;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(975, 550);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 50);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Xác nhận đã xem";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(675, 75);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(111, 70);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Xem tất cả";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnErrorTime
            // 
            btnErrorTime.Location = new Point(792, 75);
            btnErrorTime.Name = "btnErrorTime";
            btnErrorTime.Size = new Size(33, 29);
            btnErrorTime.TabIndex = 9;
            btnErrorTime.UseVisualStyleBackColor = true;
            btnErrorTime.Visible = false;
            // 
            // lbRequest
            // 
            lbRequest.AutoSize = true;
            lbRequest.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRequest.ForeColor = Color.Black;
            lbRequest.Location = new Point(271, 19);
            lbRequest.Name = "lbRequest";
            lbRequest.Size = new Size(305, 35);
            lbRequest.TabIndex = 16;
            lbRequest.Text = "Yêu cầu hỗ trợ hôm nay";
            // 
            // ViewRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(1285, 633);
            Controls.Add(lbRequest);
            Controls.Add(btnErrorTime);
            Controls.Add(btnShowAll);
            Controls.Add(btnConfirm);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtgvShow);
            Name = "ViewRequest";
            Text = "ViewRequest";
            ((System.ComponentModel.ISupportInitialize)dtgvShow).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvShow;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnToday;
        private Button btnNoView;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCountNoView;
        private Button btnCountToday;
        private TextBox txbStatus;
        private TextBox txbTimeSent;
        private TextBox txbContent;
        private TextBox txbTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbSendCode;
        private Button btnConfirm;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Button btnShowAll;
        private Button btnErrorTime;
        private Label lbRequest;
        private ToolTip ttError;
    }
}