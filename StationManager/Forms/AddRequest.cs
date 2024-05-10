using StationManager.DAO;
using StationManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationManager.Forms
{
    public partial class AddRequest : Form
    {
        private string userId;
        private DataTable rootSource;

        public AddRequest(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadHideError();
            LoadRequest();
        }
        private void LoadData(DateTime timeStart, DateTime timeEnd)
        {
            DataTable table = RequestDAO.Instance.GetDataRequest(timeStart, timeEnd);
            rootSource = table;
        }
        private void LoadHideError()
        {
            btnErrorContent.Visible = false;
            btnErrorTitle.Visible = false;
        }
        private void LoadRequest()
        {
            btnShow_Click(new object(), new EventArgs());
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            int check = 0;
            DateTime date = DateTime.Now;
            if (txbContent.Text == "")
            {
                ttError.SetToolTip(btnErrorContent, "Hãy nhập thông tin nội dung");
                btnErrorContent.Visible = true;
                check++;
            }
            if (txbTitle.Text == "")
            {
                ttError.SetToolTip(btnErrorTitle, "Hãy nhập thông tin tiêu đề");
                btnErrorTitle.Visible = true;
                check++;
            }
            if (check > 0)
            {
                return;
            }
            RequestDAO.Instance.SendRequest(txbTitle.Text, txbContent.Text, date, userId);
            MessageBox.Show("Gửi thành công");
            btnShow_Click(new object(), new EventArgs());

        }

        private void txbTitle_TextChanged(object sender, EventArgs e)
        {
            LoadHideError();
        }

        private void txbContent_TextChanged(object sender, EventArgs e)
        {
            LoadHideError();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime dateStart = dtpTimeStart.Value.Date;
            DateTime dateEnd = dtpTimeEnd.Value.Date.AddDays(1).AddTicks(-1);
            if (dateStart.Date > dateEnd.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc");
                return;
            }



            LoadData(dateStart, dateEnd);
            dtgvRequest.DataSource = table();
        }
        private DataTable table()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Mã yêu cầu"));
            dataTable.Columns.Add(new DataColumn("Tiêu đề"));
            dataTable.Columns.Add(new DataColumn("Nội dung"));
            dataTable.Columns.Add(new DataColumn("Thời gian gửi yêu cầu"));
            dataTable.Columns.Add(new DataColumn("Trạng thái"));
            if (rootSource != null && rootSource.Rows.Count > 0)
            {
                DataTable resultTable = rootSource.Clone();
                resultTable.Rows.Clear();

                foreach (DataRow row in rootSource.AsEnumerable().Where(r => r.Field<string>("LoginId") == userId))
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

        private void btnErrorTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
