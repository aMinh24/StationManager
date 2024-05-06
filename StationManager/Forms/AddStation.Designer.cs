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
            SuspendLayout();
            // 
            // cb_Status
            // 
            cb_Status.FormattingEnabled = true;
            cb_Status.Items.AddRange(new object[] { "Đang hoạt động", "Tạm dừng hoạt động", "Dừng hoạt động vĩnh viễn" });
            cb_Status.Location = new Point(291, 502);
            cb_Status.Name = "cb_Status";
            cb_Status.Size = new Size(424, 28);
            cb_Status.TabIndex = 0;
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(291, 202);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(424, 27);
            tb_Address.TabIndex = 1;
            // 
            // tb_TotalActivePort
            // 
            tb_TotalActivePort.Location = new Point(291, 405);
            tb_TotalActivePort.Name = "tb_TotalActivePort";
            tb_TotalActivePort.Size = new Size(424, 27);
            tb_TotalActivePort.TabIndex = 2;
            // 
            // tb_TotalPort
            // 
            tb_TotalPort.Location = new Point(291, 304);
            tb_TotalPort.Name = "tb_TotalPort";
            tb_TotalPort.Size = new Size(424, 27);
            tb_TotalPort.TabIndex = 2;
            // 
            // lb_AddStation
            // 
            lb_AddStation.AutoSize = true;
            lb_AddStation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_AddStation.Location = new Point(401, 61);
            lb_AddStation.Name = "lb_AddStation";
            lb_AddStation.Size = new Size(209, 46);
            lb_AddStation.TabIndex = 7;
            lb_AddStation.Text = "Add Station";
            // 
            // lb_Status
            // 
            lb_Status.AutoSize = true;
            lb_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Status.Location = new Point(119, 502);
            lb_Status.Name = "lb_Status";
            lb_Status.Size = new Size(65, 28);
            lb_Status.TabIndex = 11;
            lb_Status.Text = "Status";
            // 
            // lb_TotalActivePort
            // 
            lb_TotalActivePort.AutoSize = true;
            lb_TotalActivePort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TotalActivePort.Location = new Point(119, 401);
            lb_TotalActivePort.Name = "lb_TotalActivePort";
            lb_TotalActivePort.Size = new Size(154, 28);
            lb_TotalActivePort.TabIndex = 10;
            lb_TotalActivePort.Text = "Total Active Port";
            // 
            // lb_TotalPort
            // 
            lb_TotalPort.AutoSize = true;
            lb_TotalPort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TotalPort.Location = new Point(119, 300);
            lb_TotalPort.Name = "lb_TotalPort";
            lb_TotalPort.Size = new Size(95, 28);
            lb_TotalPort.TabIndex = 9;
            lb_TotalPort.Text = "Total Port";
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Address.Location = new Point(119, 202);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(82, 28);
            lb_Address.TabIndex = 8;
            lb_Address.Text = "Address";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(560, 611);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(155, 45);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(303, 611);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(155, 45);
            btn_Save.TabIndex = 14;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // AddStation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(lb_Status);
            Controls.Add(lb_TotalActivePort);
            Controls.Add(lb_TotalPort);
            Controls.Add(lb_Address);
            Controls.Add(lb_AddStation);
            Controls.Add(tb_TotalPort);
            Controls.Add(tb_TotalActivePort);
            Controls.Add(tb_Address);
            Controls.Add(cb_Status);
            Name = "AddStation";
            Text = "AddStation";
            VisibleChanged += AddStation_VisibleChanged;
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
    }
}