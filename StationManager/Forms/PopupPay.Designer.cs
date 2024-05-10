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
            lbTaoTaiKhoan = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txbAmount
            // 
            txbAmount.BorderStyle = BorderStyle.FixedSingle;
            txbAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbAmount.Location = new Point(50, 50);
            txbAmount.Name = "txbAmount";
            txbAmount.Size = new Size(300, 34);
            txbAmount.TabIndex = 0;
            txbAmount.KeyPress += txbAmount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 1;
            label1.Text = "Nhập số tiền:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(125, 125);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 50);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCheckStatus
            // 
            btnCheckStatus.Location = new Point(125, 200);
            btnCheckStatus.Name = "btnCheckStatus";
            btnCheckStatus.Size = new Size(150, 50);
            btnCheckStatus.TabIndex = 3;
            btnCheckStatus.Text = "Kiểm tra";
            btnCheckStatus.UseVisualStyleBackColor = true;
            btnCheckStatus.Click += btnCheckStatus_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(125, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy giao dịch";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbTaoTaiKhoan
            // 
            lbTaoTaiKhoan.AutoSize = true;
            lbTaoTaiKhoan.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaoTaiKhoan.ForeColor = Color.Black;
            lbTaoTaiKhoan.Location = new Point(116, 20);
            lbTaoTaiKhoan.Name = "lbTaoTaiKhoan";
            lbTaoTaiKhoan.Size = new Size(368, 35);
            lbTaoTaiKhoan.TabIndex = 16;
            lbTaoTaiKhoan.Text = "Nạp tiền vào donate cho app";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnCheckStatus);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbAmount);
            panel1.Location = new Point(100, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 350);
            panel1.TabIndex = 17;
            // 
            // PopupPay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(582, 453);
            Controls.Add(panel1);
            Controls.Add(lbTaoTaiKhoan);
            Name = "PopupPay";
            Text = "PopupPay";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbAmount;
        private Label label1;
        private Button btnConfirm;
        private Button btnCheckStatus;
        private Button btnCancel;
        private Label lbTaoTaiKhoan;
        private Panel panel1;
    }
}