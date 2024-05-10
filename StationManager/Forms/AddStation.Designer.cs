namespace StationManager.Forms
{
    partial class AddStation
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
            cb_Status = new ComboBox();
            tb_Address = new TextBox();
            tb_TotalActivePort = new TextBox();
            tb_TotalPort = new TextBox();
            lb_AddStation = new Label();
            lb_Status = new Label();
            lb_TotalActivePort = new Label();
            lb_TotalPort = new Label();
            lb_Address = new Label();
            btn_Cancel = new Button();
            btn_Save = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_Status
            // 
            cb_Status.FormattingEnabled = true;
            cb_Status.Items.AddRange(new object[] { "Đang hoạt động", "Tạm dừng hoạt động", "Dừng hoạt động vĩnh viễn" });
            cb_Status.Location = new Point(50, 350);
            cb_Status.Name = "cb_Status";
            cb_Status.Size = new Size(300, 28);
            cb_Status.TabIndex = 0;
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(50, 50);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(300, 27);
            tb_Address.TabIndex = 1;
            // 
            // tb_TotalActivePort
            // 
            tb_TotalActivePort.Location = new Point(50, 250);
            tb_TotalActivePort.Name = "tb_TotalActivePort";
            tb_TotalActivePort.Size = new Size(300, 27);
            tb_TotalActivePort.TabIndex = 2;
            // 
            // tb_TotalPort
            // 
            tb_TotalPort.Location = new Point(50, 150);
            tb_TotalPort.Name = "tb_TotalPort";
            tb_TotalPort.Size = new Size(300, 27);
            tb_TotalPort.TabIndex = 2;
            // 
            // lb_AddStation
            // 
            lb_AddStation.AutoSize = true;
            lb_AddStation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_AddStation.Location = new Point(202, 31);
            lb_AddStation.Name = "lb_AddStation";
            lb_AddStation.Size = new Size(209, 46);
            lb_AddStation.TabIndex = 7;
            lb_AddStation.Text = "Add Station";
            // 
            // lb_Status
            // 
            lb_Status.AutoSize = true;
            lb_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Status.Location = new Point(50, 319);
            lb_Status.Name = "lb_Status";
            lb_Status.Size = new Size(65, 28);
            lb_Status.TabIndex = 11;
            lb_Status.Text = "Status";
            // 
            // lb_TotalActivePort
            // 
            lb_TotalActivePort.AutoSize = true;
            lb_TotalActivePort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TotalActivePort.Location = new Point(50, 219);
            lb_TotalActivePort.Name = "lb_TotalActivePort";
            lb_TotalActivePort.Size = new Size(154, 28);
            lb_TotalActivePort.TabIndex = 10;
            lb_TotalActivePort.Text = "Total Active Port";
            // 
            // lb_TotalPort
            // 
            lb_TotalPort.AutoSize = true;
            lb_TotalPort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TotalPort.Location = new Point(50, 119);
            lb_TotalPort.Name = "lb_TotalPort";
            lb_TotalPort.Size = new Size(95, 28);
            lb_TotalPort.TabIndex = 9;
            lb_TotalPort.Text = "Total Port";
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Address.Location = new Point(50, 19);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(82, 28);
            lb_Address.TabIndex = 8;
            lb_Address.Text = "Address";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(350, 531);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(150, 50);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(100, 531);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(150, 50);
            btn_Save.TabIndex = 14;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(lb_Status);
            panel1.Controls.Add(lb_TotalActivePort);
            panel1.Controls.Add(lb_TotalPort);
            panel1.Controls.Add(lb_Address);
            panel1.Controls.Add(tb_TotalPort);
            panel1.Controls.Add(tb_TotalActivePort);
            panel1.Controls.Add(tb_Address);
            panel1.Controls.Add(cb_Status);
            panel1.Location = new Point(100, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 410);
            panel1.TabIndex = 16;
            // 
            // AddStation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            ClientSize = new Size(600, 600);
            Controls.Add(panel1);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(lb_AddStation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStation";
            Text = "AddStation";
            VisibleChanged += AddStation_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Status;
        private TextBox tb_Address;
        private TextBox tb_TotalActivePort;
        private TextBox tb_TotalPort;
        private Label lb_AddStation;
        private Label lb_Status;
        private Label lb_TotalActivePort;
        private Label lb_TotalPort;
        private Label lb_Address;
        private Button btn_Cancel;
        private Button btn_Save;
        private Panel panel1;
    }
}