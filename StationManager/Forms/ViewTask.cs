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
using System.Windows.Forms.DataVisualization.Charting;

namespace StationManager.Forms
{
    public partial class ViewTask : Form
    {
        AddTask addTask = new AddTask();
        public ViewTask()
        {
            InitializeComponent();
            loadListTask();
            addTaskBinding();
            addTask.DataUpdate += AddTask_DataUpdated;
            setFormatGrid();
        }
        void setFormatGrid()
        {
            dtgvCongViec.Columns[0].HeaderText = "Mã công việc";
            dtgvCongViec.Columns[1].HeaderText = "Tiêu đề";
            dtgvCongViec.Columns[2].HeaderText = "Nội dung";
            dtgvCongViec.Columns[3].HeaderText = "Thời gian bắt đầu";
            dtgvCongViec.Columns[4].HeaderText = "Thời gian kết thúc";
            dtgvCongViec.Columns[5].HeaderText = "Mã nhân viên";
        }

        private void AddTask_DataUpdated(object? sender, EventArgs e)
        {
            loadListTask();
        }
        void loadListTask()
        {
            dtgvCongViec.DataSource = TaskDAO.Instance.getTaskList();
            txtMaCV.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            txtTieuDe.ReadOnly = true;
            txtNoiDung.ReadOnly = true;
            dtpBatDau.Enabled = false;
            dtpKetThuc.Enabled = false;
        }

        void addTaskBinding()
        {
            txtMaCV.DataBindings.Add(new Binding("Text", dtgvCongViec.DataSource, "taskID", true, DataSourceUpdateMode.Never));
            txtMaNV.DataBindings.Add(new Binding("Text", dtgvCongViec.DataSource, "employeeID", true, DataSourceUpdateMode.Never));
            txtTieuDe.DataBindings.Add(new Binding("Text", dtgvCongViec.DataSource, "taskTitle", true, DataSourceUpdateMode.Never));
            txtNoiDung.DataBindings.Add(new Binding("Text", dtgvCongViec.DataSource, "taskDescription", true, DataSourceUpdateMode.Never));
            dtpBatDau.DataBindings.Add(new Binding("Value", dtgvCongViec.DataSource, "taskStart", true, DataSourceUpdateMode.Never));
            dtpKetThuc.DataBindings.Add(new Binding("value", dtgvCongViec.DataSource, "taskEnd", true, DataSourceUpdateMode.Never));
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewTask_Load(object sender, EventArgs e)
        {

        }

        private void dtgvCongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addTask.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text;
            string maNV = txtMaNV.Text;
            string noiDung = txtNoiDung.Text;
            string tieuDe = txtTieuDe.Text;
            DateTime batDau = dtpBatDau.Value;
            DateTime ketTHuc = dtpKetThuc.Value;

            if (TaskDAO.Instance.UpdateTask(maNV, maCV, tieuDe, noiDung, batDau, ketTHuc))
            {
                MessageBox.Show("Edited Task Successully");
                loadListTask();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text;
            if (TaskDAO.Instance.DeleteTask(maCV))
            {
                MessageBox.Show("Deleted Task Successully");
                loadListTask();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtTieuDe.ReadOnly = false;
            txtNoiDung.ReadOnly = false;
            dtpBatDau.Enabled = true;
            dtpKetThuc.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadListTask();
        }

        private void dtpBatDau_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
