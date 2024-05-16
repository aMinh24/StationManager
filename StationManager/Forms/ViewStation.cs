using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client.NativeInterop;
using StationManager.DAO;
using StationManager.DTO;
using StationManager.Service;
using static System.Windows.Forms.AxHost;

namespace StationManager.Forms
{
    public partial class ViewStation : Form
    {
        private DTO.Account owner;

        AddStation addStation = new AddStation();
        EditStation editStation = new EditStation();
        private List<Station> stationList = new List<Station>();

        public ViewStation(DTO.Account acc)
        {
            InitializeComponent();
            this.owner = acc;
            editStation.Visible = false;
            editStation.DataUpdated += EditStation_DataUpdated;
            addStation.DataUpdated += AddStation_DataUpdated;
            loadData();
            if (AccountDAO.GetRole(owner.LoginID) == "User")
            {
                btn_Add.Visible = false;
                btn_Delete.Visible = false;
                dtgv_Station.Columns["Edit"].Visible = false;
            }
        }

        private void AddStation_DataUpdated(object? sender, EventArgs e)
        {
            loadData();
        }

        private void EditStation_DataUpdated(object? sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            stationList = StationDAO.getStationList();
            dtgv_Station.DataSource = stationList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Station.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                //if (account.Level >= AccountDAO.Instance.getLevelByContractId(Convert.ToInt32(dtgv_Station.Rows[e.RowIndex].Cells[2].Value.ToString())))
                //{
                string stationId = dtgv_Station.Rows[e.RowIndex].Cells[2].Value.ToString();
                Station station = stationList.Find(stat => stat.StationId == stationId);
                editStation.Station = station;
                editStation.Visible = true;
                editStation.BringToFront();
                //}
                //else
                //{
                //    MessageBox.Show("Bạn cần quyền truy cập để chỉnh sửa hợp đồng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to delete selected stations?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> stationIdList = new List<string>();
                List<Station> tempList = new List<Station>();
                dtgv_Station.DataSource = tempList;
                foreach (Station stat in stationList)
                {
                    if (stat.IsChecked == false)
                    {
                        continue;
                    }
                    if (stat.IsChecked && stat.Status.Equals("Dừng hoạt động vĩnh viễn"))
                    {
                        stationIdList.Add(stat.StationId);
                    }
                    else
                    {
                        dtgv_Station.DataSource = stationList;
                        MessageBox.Show("Active stations cannot be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                stationList.RemoveAll(stat => stat.IsChecked);
                foreach (string id in stationIdList)
                {
                    StationDAO.deleteStationById(id);
                }
                dtgv_Station.DataSource = stationList;
                MessageBox.Show("Station has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addStation.Visible = true;
        }

        private void lb_ViewStation_Click(object sender, EventArgs e)
        {

        }
    }
}
