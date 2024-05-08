namespace StationManager.Forms
{
    partial class PopupPay
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
            txbAmount = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnCheckStatus = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txbAmount
            // 
            txbAmount.Location = new Point(316, 129);
            txbAmount.Name = "txbAmount";
            txbAmount.Size = new Size(248, 27);
            txbAmount.TabIndex = 0;
            txbAmount.KeyPress += txbAmount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 136);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập số tiền:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(316, 242);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(124, 37);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.Location = new Point(473, 242);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(124, 37);
            btnCheckStatus.TabIndex = 3;
            btnCheckStatus.Text = "Kiểm tra";
            btnCheckStatus.UseVisualStyleBackColor = true;
            btnCheckStatus.Click += btnCheckStatus_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(473, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 37);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy giao dịch";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PopupPay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnCheckStatus);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(txbAmount);
            Name = "PopupPay";
            Text = "PopupPay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbAmount;
        private Label label1;
        private Button btnConfirm;
        private Button btnCheckStatus;
        private Button btnCancel;
    }
}