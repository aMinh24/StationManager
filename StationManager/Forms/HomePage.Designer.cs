namespace StationManager.Forms
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            btnAccount = new Button();
            btnStation = new Button();
            btnRequest = new Button();
            btnReport = new Button();
            btnPay = new Button();
            label1 = new Label();
            btnTask = new Button();
            panel1 = new Panel();
            lbBalance = new TextBox();
            pictureBox1 = new PictureBox();
            lb_Welcom = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(50, 500);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(150, 50);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnStation
            // 
            btnStation.Location = new Point(50, 125);
            btnStation.Name = "btnStation";
            btnStation.Size = new Size(150, 50);
            btnStation.TabIndex = 1;
            btnStation.Text = "Trạm sạc";
            btnStation.UseVisualStyleBackColor = true;
            btnStation.Click += btnStation_Click;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(50, 200);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(150, 50);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Yêu cầu";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(50, 425);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 50);
            btnReport.TabIndex = 3;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(50, 275);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(150, 50);
            btnPay.TabIndex = 4;
            btnPay.Text = "Nạp tiền";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 575);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 5;
            label1.Text = "Số tiền:";
            // 
            // btnTask
            // 
            btnTask.Location = new Point(50, 350);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(150, 50);
            btnTask.TabIndex = 7;
            btnTask.Text = "Công việc";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbBalance);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnTask);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnStation);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 673);
            panel1.TabIndex = 9;
            // 
            // lbBalance
            // 
            lbBalance.BorderStyle = BorderStyle.FixedSingle;
            lbBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBalance.Location = new Point(50, 609);
            lbBalance.Name = "lbBalance";
            lbBalance.ReadOnly = true;
            lbBalance.Size = new Size(150, 38);
            lbBalance.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lb_Welcom
            // 
            lb_Welcom.AutoSize = true;
            lb_Welcom.Dock = DockStyle.Top;
            lb_Welcom.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_Welcom.ForeColor = Color.Black;
            lb_Welcom.Location = new Point(250, 0);
            lb_Welcom.Name = "lb_Welcom";
            lb_Welcom.Size = new Size(393, 50);
            lb_Welcom.TabIndex = 10;
            lb_Welcom.Text = "Welcom back Admin!";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 673);
            Controls.Add(lb_Welcom);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "HomePage";
            Text = "HomePage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccount;
        private Button btnStation;
        private Button btnRequest;
        private Button btnReport;
        private Button btnPay;
        private Label label1;
        private Button btnTask;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox lbBalance;
        private Label lb_Welcom;
    }
}