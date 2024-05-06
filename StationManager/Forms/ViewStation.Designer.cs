namespace StationManager.Forms
{
    partial class ViewStation
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
            dtgv_Station = new DataGridView();
            IsChecked = new DataGridViewCheckBoxColumn();
            StationId = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            TotalPort = new DataGridViewTextBoxColumn();
            TotalActivePort = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            lb_ViewStation = new Label();
            btn_Delete = new Button();
            btn_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_Station).BeginInit();
            SuspendLayout();
            // 
            // dtgv_Station
            // 
            dtgv_Station.AllowUserToAddRows = false;
            dtgv_Station.AllowUserToDeleteRows = false;
            dtgv_Station.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Station.Columns.AddRange(new DataGridViewColumn[] { IsChecked, StationId, Address, TotalPort, TotalActivePort, Status, Edit });
            dtgv_Station.Location = new Point(53, 158);
            dtgv_Station.Name = "dtgv_Station";
            dtgv_Station.RowHeadersWidth = 51;
            dtgv_Station.Size = new Size(928, 462);
            dtgv_Station.TabIndex = 0;
            dtgv_Station.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IsChecked
            // 
            IsChecked.DataPropertyName = "isChecked";
            IsChecked.HeaderText = "";
            IsChecked.MinimumWidth = 6;
            IsChecked.Name = "IsChecked";
            IsChecked.Width = 125;
            // 
            // StationId
            // 
            StationId.DataPropertyName = "stationId";
            StationId.HeaderText = "Station Id";
            StationId.MinimumWidth = 6;
            StationId.Name = "StationId";
            StationId.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // TotalPort
            // 
            TotalPort.DataPropertyName = "totalPort";
            TotalPort.HeaderText = "Toltal Port";
            TotalPort.MinimumWidth = 6;
            TotalPort.Name = "TotalPort";
            TotalPort.Width = 125;
            // 
            // TotalActivePort
            // 
            TotalActivePort.DataPropertyName = "totalActivePort";
            TotalActivePort.HeaderText = "Total Active Port";
            TotalActivePort.MinimumWidth = 6;
            TotalActivePort.Name = "TotalActivePort";
            TotalActivePort.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 125;
            // 
            // lb_ViewStation
            // 
            lb_ViewStation.AutoSize = true;
            lb_ViewStation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ViewStation.Location = new Point(396, 55);
            lb_ViewStation.Name = "lb_ViewStation";
            lb_ViewStation.Size = new Size(221, 46);
            lb_ViewStation.TabIndex = 1;
            lb_ViewStation.Text = "View Station";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(525, 642);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(161, 57);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(288, 642);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(161, 57);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // ViewStation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(btn_Add);
            Controls.Add(btn_Delete);
            Controls.Add(lb_ViewStation);
            Controls.Add(dtgv_Station);
            Name = "ViewStation";
            Text = "Station";
            ((System.ComponentModel.ISupportInitialize)dtgv_Station).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_Station;
        private Label lb_ViewStation;
        private Button btn_Delete;
        private DataGridViewCheckBoxColumn IsChecked;
        private DataGridViewTextBoxColumn StationId;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn TotalPort;
        private DataGridViewTextBoxColumn TotalActivePort;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewImageColumn Edit;
        private Button btn_Add;
    }
}