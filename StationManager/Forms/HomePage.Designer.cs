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
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 669);
            Controls.Add(btnReport);
            Controls.Add(btnRequest);
            Controls.Add(btnStation);
            Controls.Add(btnAccount);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAccount;
        private Button btnStation;
        private Button btnRequest;
        private Button btnReport;
    }
}