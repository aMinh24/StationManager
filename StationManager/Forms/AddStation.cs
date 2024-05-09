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
    public partial class AddStation : Form
    {
        public event EventHandler DataUpdated;

        public AddStation()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void OnDataUpdated(EventArgs e)
        {
            EventHandler handler = DataUpdated;
            handler?.Invoke(this, e);
        }

        private void AddStation_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Address.Text == "" || tb_TotalPort.Text == "" || tb_TotalActivePort.Text == "")
            {
                MessageBox.Show("Station information cannot be left blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(tb_TotalPort.Text) < Convert.ToInt32(tb_TotalActivePort.Text))
            {
                MessageBox.Show("Total active port cannot be greater than total port!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StationDAO.addStation(tb_Address.Text, Convert.ToInt32(tb_TotalPort.Text), Convert.ToInt32(tb_TotalActivePort.Text), cb_Status.SelectedItem.ToString());
                MessageBox.Show("Station information has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Address.Clear();
                tb_TotalPort.Clear();
                tb_TotalActivePort.Clear();
                cb_Status.Text = "";
                OnDataUpdated(EventArgs.Empty);
            }
        }
    }
}
