using StationManager.DAO;
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
    public partial class AddTask : Form
    {
        public event EventHandler DataUpdate;

        public void OnDataUpdate(EventArgs e)
        {
            EventHandler handler = DataUpdate;
            handler?.Invoke(this, e);
        }
        public AddTask()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text;
            string maNV = txtMaNV.Text;
            string noiDung = txtNoiDung.Text;
            string tieuDe = txtTieuDe.Text;
            DateTime batDau = dtpBatDau.Value;
            DateTime ketTHuc = dtpKetThuc.Value;

            if (TaskDAO.Instance.InsertTask(maNV, maCV, tieuDe, noiDung, batDau, ketTHuc))
            {
                MessageBox.Show("Added Task Successully");
                OnDataUpdate(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }
    }
}
