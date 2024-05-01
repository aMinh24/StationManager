using StationManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationManager.Forms
{
    public partial class ViewReport : Form
    {
        DataTable rootTable;
        public ViewReport()
        {
            InitializeComponent();
            Setup();
        }
        private void Setup()
        {
            rootTable = ReportDAO.GetAllReport();
            dtgvReport.Columns.Clear();
            dtgvReport.DataSource = rootTable;
            LoadInforBinding();
            ChangeNameColumn();
        }
        private void ChangeNameColumn()
        {
            dtgvReport.Columns[0].HeaderText = "Mã báo cáo";
            dtgvReport.Columns[1].HeaderText = "Tiêu đề";
            dtgvReport.Columns[2].HeaderText = "Nội dung";
            dtgvReport.Columns[3].HeaderText = "File đã gửi";
            dtgvReport.Columns[4].HeaderText = "Thời gian gửi";
            dtgvReport.Columns[5].HeaderText = "Mã nhân viên";
        }
        private void LoadInforBinding()
        {
            ClearAllBinding();
            BindingControl(txbId, "ReportId");
            BindingControl(txbTitle, "Title");
            BindingControl(txbContent, "Content");
            BindingControl(txbFile, "FileUpload");
            BindingControl(txbEmployeeId, "EmployeeId");
            BindingControl(txbSent, "TimeSent");
        }
        private void ClearAllBinding()
        {
            ClearBinding(txbContent);
            ClearBinding(txbEmployeeId);
            ClearBinding(txbSent);
            ClearBinding(txbId);
            ClearBinding(txbFile);
            ClearBinding(txbTitle);
        }
        private void ClearBinding(Control control)
        {
            control.DataBindings.Clear();
        }
        private void BindingControl(Control control, string datamember)
        {
            control.DataBindings.Add(new Binding("Text", dtgvReport.DataSource, datamember, true, DataSourceUpdateMode.Never));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReport addReport = new AddReport();
            addReport.ShowDialog();
            Setup();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddReport addReport = new AddReport(txbId.Text, txbTitle.Text, txbContent.Text, txbFile.Text, txbEmployeeId.Text);
            addReport.ShowDialog();
            Setup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có muốn xóa báo cáo số {txbId.Text}?", "Attention!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ReportDAO.DeleteReport(txbId.Text);
                Setup();
            }
        }
    }

}
