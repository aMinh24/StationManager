using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StationManager.DAO;
using StationManager.DTO;

namespace StationManager.Forms
{
    public partial class EditStation : Form
    {
        public event EventHandler DataUpdated;
        private Station station;
        public Station Station { get => station; set => station = value; }

        public EditStation()
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

        private void EditStation_Load(object sender, EventArgs e)
        {

        }

        private void EditStation_VisibleChanged(object sender, EventArgs e)
        {
            tb_StationId.Text = station.StationId;
            tb_Address.Text = station.Address;
            tb_TotalPort.Text = Convert.ToString(station.TotalPort);
            tb_TotalActivePort.Text = Convert.ToString(station.TotalActivePort);
            cb_Status.Text = station.Status;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_StationId.Text == "" || tb_Address.Text == "" || tb_TotalPort.Text == "" || tb_TotalActivePort.Text == "")
            {
                MessageBox.Show("Station information cannot be left blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(tb_TotalPort.Text) < Convert.ToInt32(tb_TotalActivePort.Text))
            {
                MessageBox.Show("Total active port cannot be greater than total port!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StationDAO.updateStation(tb_StationId.Text, tb_Address.Text, Convert.ToInt32(tb_TotalPort.Text), Convert.ToInt32(tb_TotalActivePort.Text), cb_Status.SelectedItem.ToString());
                MessageBox.Show("Station information has been edited.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnDataUpdated(EventArgs.Empty);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
