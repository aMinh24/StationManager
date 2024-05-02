using Microsoft.VisualBasic.ApplicationServices;
using StationManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationManager.Forms
{
    public partial class ViewRequest : Form
    {
        DataTable rootSourceToday;
        DataTable rootSourceNoView;

        public ViewRequest()
        {

            InitializeComponent();
            Task.Run
            (async () =>
            {

                LoadDataToday();
                LoadDataNoView();
                LoadCountNoView();
                LoadCountToday();
            });
            //LoadInforBinding();
        }
        private void LoadCountNoView()
        {
            if (btnCountNoView.InvokeRequired)
            {
                btnCountNoView.BeginInvoke(new Action(() =>
                {
                    btnCountNoView.Text = CountNoView().ToString();
                }));
            }
            else
            {
                btnCountNoView.Text = CountNoView().ToString();

            }
        }
        private void LoadCountToday()
        {
            if (btnCountToday.InvokeRequired)
            {
                btnCountToday.BeginInvoke(new Action(() =>
                {
                    btnCountToday.Text = CountToday().ToString();
                }));
            }
            else
            {
                btnCountToday.Text = CountToday().ToString();

            }
        }
        private void LoadDataToday()
        {
            DateTime currentDate = DateTime.Today;
            DateTime dateStart = currentDate.Date;
            DateTime dateEnd = currentDate.Date.AddDays(1).AddTicks(-1);
            if (dtgvShow.InvokeRequired)
            {
                dtgvShow.BeginInvoke(new Action(() =>
                {
                    DataTable table = RequestDAO.Instance.GetDataRequest(dateStart, dateEnd);
                    rootSourceToday = table;
                    btnCountToday_Click(new object { }, new EventArgs { });
                }));
            }
            else
            {
                DataTable table = RequestDAO.Instance.GetDataRequest(dateStart, dateEnd);
                rootSourceToday = table;
            }

        }

        private void LoadDataNoView()
        {

            if (dtgvShow.InvokeRequired)
            {
                dtgvShow.BeginInvoke(new Action(() =>
                {
                    DataTable table = RequestDAO.Instance.RequestNoView();
                    rootSourceNoView = table;
                }));
            }
            else
            {
                DataTable table = RequestDAO.Instance.RequestNoView();
                rootSourceNoView = table;
            }

        }
        private DataTable RequestNoView()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Mã yêu cầu"));
            dataTable.Columns.Add(new DataColumn("Tiêu đề"));
            dataTable.Columns.Add(new DataColumn("Nội dung"));
            dataTable.Columns.Add(new DataColumn("Thời gian gửi yêu cầu"));
            dataTable.Columns.Add(new DataColumn("Trạng thái"));
            if (rootSourceNoView != null && rootSourceNoView.Rows.Count > 0)
            {
                DataTable resultTable = rootSourceNoView.Clone();
                resultTable.Rows.Clear();

                foreach (DataRow row in rootSourceNoView.AsEnumerable())
                {
                    var reportCode = row.Field<string>(0);
                    var staffCode = row.Field<string>(1);
                    var reportName = row.Field<string>(2);
                    var reportTime = row.Field<DateTime>(3);
                    var status = row.Field<string>(4);
                    dataTable.Rows.Add(reportCode, staffCode, reportName, reportTime, status);
                }
            }
            return dataTable;
        }
        private DataTable RequestToday()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Mã yêu cầu"));
            dataTable.Columns.Add(new DataColumn("Tiêu đề"));
            dataTable.Columns.Add(new DataColumn("Nội dung"));
            dataTable.Columns.Add(new DataColumn("Thời gian gửi yêu cầu"));
            dataTable.Columns.Add(new DataColumn("Trạng thái"));
            if (rootSourceToday != null && rootSourceToday.Rows.Count > 0)
            {
                DataTable resultTable = rootSourceToday.Clone();
                resultTable.Rows.Clear();

                foreach (DataRow row in rootSourceToday.AsEnumerable())
                {
                    var reportCode = row.Field<string>(0);
                    var staffCode = row.Field<string>(1);
                    var reportName = row.Field<string>(2);
                    var reportTime = row.Field<DateTime>(3);
                    var status = row.Field<string>(4);
                    dataTable.Rows.Add(reportCode, staffCode, reportName, reportTime, status);
                }
            }
            return dataTable;
        }
        private int CountNoView()
        {
            int count = 0;
            foreach (DataRow row in rootSourceNoView.AsEnumerable())
            {
                count++;
            }

            return count;
        }
        private int CountToday()
        {
            int count = 0;
            foreach (DataRow row in rootSourceToday.AsEnumerable())
            {
                count++;
            }

            return count;
        }

        private void btnCountNoView_Click(object sender, EventArgs e)
        {
            dtgvShow.DataSource = RequestNoView();
            lbRequest.Text = "Yêu cầu hỗ trợ chưa xem";
            LoadInforBinding();

        }

        private void btnNoView_Click(object sender, EventArgs e)
        {
            dtgvShow.DataSource = RequestNoView();
            lbRequest.Text = "Yêu cầu hỗ trợ chưa xem";
            LoadInforBinding();

        }

        private void btnCountToday_Click(object sender, EventArgs e)
        {
            dtgvShow.DataSource = RequestToday();
            lbRequest.Text = "Yêu cầu hỗ trợ hôm nay";
            LoadInforBinding();

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtgvShow.DataSource = RequestToday();
            lbRequest.Text = "Yêu cầu hỗ trợ hôm nay";
            LoadInforBinding();


        }
        private void LoadInforBinding()
        {
            ClearAllBinding();
            BindingControl(txbSendCode, "Mã yêu cầu");
            BindingControl(txbTitle, "Tiêu đề");
            BindingControl(txbContent, "Nội dung");
            BindingControl(txbTimeSent, "Thời gian gửi yêu cầu");
            BindingControl(txbStatus, "Trạng thái");
        }
        private void ClearAllBinding()
        {
            ClearBinding(txbSendCode);
            ClearBinding(txbTitle);
            ClearBinding(txbContent);
            ClearBinding(txbTimeSent);
            ClearBinding(txbStatus);
        }
        private void ClearBinding(Control control)
        {
            control.DataBindings.Clear();
        }
        private void BindingControl(Control control, string datamember)
        {
            control.DataBindings.Add(new Binding("Text", dtgvShow.DataSource, datamember, true, DataSourceUpdateMode.Never));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txbSendCode.Text != "")
            {
                if (MessageBox.Show(string.Format($"Bạn có chắc xác nhận yêu cầu hỗ trợ {txbSendCode.Text}"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    RequestDAO.Instance.UpdateRequest(txbSendCode.Text);
                    MessageBox.Show("Cập nhật thành công");
                    LoadDataNoView();
                    LoadCountNoView();
                    btnNoView_Click(new object{ },new  EventArgs { });
                }

            }
        }
        //private void BindingControlTime(TextBox textBox, string dataMember)
        //{
        //    Binding binding = new Binding("Text", dtgvShow.DataSource, dataMember);
        //    binding.Format += (s, args) => args.Value = ((DateTime)args.Value).ToString("dd-MM-yyy hh:mm:");
        //    textBox.DataBindings.Add(binding);
        //}
    }
}
