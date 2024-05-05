namespace StationManager.Forms
{
    partial class EditStation
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
            lb_StationId = new Label();
            lb_EditStation = new Label();
            lb_Address = new Label();
            lb_TotalPort = new Label();
            lb_TotalActivePort = new Label();
            lb_Status = new Label();
            tb_StationId = new TextBox();
            tb_Address = new TextBox();
            tb_TotalPort = new TextBox();
            tb_TotalActivePort = new TextBox();
            cb_Status = new ComboBox();
            btn_Save = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // lb_StationId
            // 
            lb_StationId.AutoSize = true;
            lb_StationId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_StationId.Location = new Point(165, 141);
            lb_StationId.Name = "lb_StationId";
            lb_StationId.Size = new Size(96, 28);
            lb_StationId.TabIndex = 0;
            lb_StationId.Text = "Station Id";
            // 
            // lb_EditStation
            // 
            lb_EditStation.AutoSize = true;
            lb_EditStation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_EditStation.Location = new Point(412, 50);
            lb_EditStation.Name = "lb_EditStation";
            lb_EditStation.Size = new Size(205, 46);
            lb_EditStation.TabIndex = 2;
            lb_EditStation.Text = "Edit Station";
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Address.Location = new Point(165, 218);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(82, 28);
            lb_Address.TabIndex = 3;
            lb_Address.Text = "Address";
            // 
            // lb_TotalPort
            // 
            lb_TotalPort.AutoSize = true;
            lb_TotalPort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TotalPort.Location = new Point(165, 316);
            lb_TotalPort.Name = "lb_TotalPort";
            lb_TotalPort.Size = new Size(95, 28);
            lb_TotalPort.TabIndex = 4;
            lb_TotalPort.Text = "Total Port";
            // 
            // lb_TotalActivePort
            // 
            lb_TotalActivePort.AutoSize = true;
            lb_TotalActivePort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TotalActivePort.Location = new Point(165, 417);
            lb_TotalActivePort.Name = "lb_TotalActivePort";
            lb_TotalActivePort.Size = new Size(154, 28);
            lb_TotalActivePort.TabIndex = 5;
            lb_TotalActivePort.Text = "Total Active Port";
            // 
            // lb_Status
            // 
            lb_Status.AutoSize = true;
            lb_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Status.Location = new Point(165, 518);
            lb_Status.Name = "lb_Status";
            lb_Status.Size = new Size(65, 28);
            lb_Status.TabIndex = 6;
            lb_Status.Text = "Status";
            // 
            // tb_StationId
            // 
            tb_StationId.Font = new Font("Segoe UI", 12F);
            tb_StationId.Location = new Point(359, 142);
            tb_StationId.Name = "tb_StationId";
            tb_StationId.ReadOnly = true;
            tb_StationId.Size = new Size(371, 34);
            tb_StationId.TabIndex = 7;
            // 
            // tb_Address
            // 
            tb_Address.Font = new Font("Segoe UI", 12F);
            tb_Address.Location = new Point(359, 222);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(371, 34);
            tb_Address.TabIndex = 8;
            // 
            // tb_TotalPort
            // 
            tb_TotalPort.Font = new Font("Segoe UI", 12F);
            tb_TotalPort.Location = new Point(359, 320);
            tb_TotalPort.Name = "tb_TotalPort";
            tb_TotalPort.Size = new Size(371, 34);
            tb_TotalPort.TabIndex = 9;
            // 
            // tb_TotalActivePort
            // 
            tb_TotalActivePort.Font = new Font("Segoe UI", 12F);
            tb_TotalActivePort.Location = new Point(359, 421);
            tb_TotalActivePort.Name = "tb_TotalActivePort";
            tb_TotalActivePort.Size = new Size(371, 34);
            tb_TotalActivePort.TabIndex = 10;
            // 
            // cb_Status
            // 
            cb_Status.Font = new Font("Segoe UI", 12F);
            cb_Status.FormattingEnabled = true;
            cb_Status.Items.AddRange(new object[] { "Đang hoạt động", "Tạm dừng hoạt động", "Dừng hoạt động vĩnh viễn" });
            cb_Status.Location = new Point(359, 518);
            cb_Status.Name = "cb_Status";
            cb_Status.Size = new Size(371, 36);
            cb_Status.TabIndex = 11;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(287, 635);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(155, 45);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(544, 635);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(155, 45);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // EditStation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(cb_Status);
            Controls.Add(tb_TotalActivePort);
            Controls.Add(tb_TotalPort);
            Controls.Add(tb_Address);
            Controls.Add(tb_StationId);
            Controls.Add(lb_Status);
            Controls.Add(lb_TotalActivePort);
            Controls.Add(lb_TotalPort);
            Controls.Add(lb_Address);
            Controls.Add(lb_EditStation);
            Controls.Add(lb_StationId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditStation";
            Text = "EditStation";
            Load += EditStation_Load;
            VisibleChanged += EditStation_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_StationId;
        private Label lb_EditStation;
        private Label lb_Address;
        private Label lb_TotalPort;
        private Label lb_TotalActivePort;
        private Label lb_Status;
        private TextBox tb_StationId;
        private TextBox tb_Address;
        private TextBox tb_TotalPort;
        private TextBox tb_TotalActivePort;
        private ComboBox cb_Status;
        private Button btn_Save;
        private Button btn_Cancel;
    }
}