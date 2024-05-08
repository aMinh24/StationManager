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
            btnAccount = new Button();
            btnStation = new Button();
            btnRequest = new Button();
            btnReport = new Button();
            btnPay = new Button();
            label1 = new Label();
            lbBalance = new Label();
            SuspendLayout();
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(12, 68);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(142, 56);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnStation
            // 
            btnStation.Location = new Point(12, 130);
            btnStation.Name = "btnStation";
            btnStation.Size = new Size(142, 56);
            btnStation.TabIndex = 1;
            btnStation.Text = "Trạm sạc";
            btnStation.UseVisualStyleBackColor = true;
            btnStation.Click += btnStation_Click;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(12, 192);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(142, 56);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Yêu cầu";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(12, 254);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(142, 56);
            btnReport.TabIndex = 3;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(12, 316);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(142, 56);
            btnPay.TabIndex = 4;
            btnPay.Text = "Nạp tiền";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(677, 46);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 5;
            label1.Text = "Số tiền:";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Font = new Font("Segoe UI", 14F);
            lbBalance.Location = new Point(777, 46);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(41, 32);
            lbBalance.TabIndex = 6;
            lbBalance.Text = "0đ";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 669);
            Controls.Add(lbBalance);
            Controls.Add(label1);
            Controls.Add(btnPay);
            Controls.Add(btnReport);
            Controls.Add(btnRequest);
            Controls.Add(btnStation);
            Controls.Add(btnAccount);
            Name = "HomePage";
            Text = "HomePage";
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
        private Label lbBalance;
    }
}