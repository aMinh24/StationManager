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
    public partial class HomePage : Form
    {
        Account owner;
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ViewAccount viewAccount = new ViewAccount();
            viewAccount.Show();
        }
        public HomePage(Account acc)
        {
            InitializeComponent();
            this.owner = acc;
            lbBalance.Text = $"{owner.balance} VNĐ";
            panel1.BackColor = Color.FromArgb(128, 192, 192, 192);
            label1 .BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            lb_Welcom.BackColor = Color.Transparent;
            if (AccountDAO.GetRole(owner.LoginID) == "User")
            {
                btnAccount.Visible = false;
                btnTask.Visible = false;
                btnReport.Visible = false;
                label1.Location = new System.Drawing.Point(50, 350);
                lbBalance.Location = new System.Drawing.Point(50, 384);
                lb_Welcom.Text = "Welcom back User!";
                btnStation.Text = "Xem trạm sạc";
                btnRequest.Text = "Gửi yêu cầu";
            }
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            ViewStation viewStation = new ViewStation(owner);
            viewStation.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (AccountDAO.GetRole(owner.LoginID) == "User")
            {
                AddRequest rq = new AddRequest(owner.LoginID);
                rq.Show();
            }
            else
            {
                ViewRequest viewRequest = new ViewRequest();
                viewRequest.Show();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PopupPay popupPay = new PopupPay(owner);
            popupPay.ShowDialog();
            owner = AccountDAO.CheckLogin(owner.LoginID, owner.Password);
            lbBalance.Text = $"{owner.balance} VNĐ";
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            ViewTask viewTask = new ViewTask();
            viewTask.Show();
        }
    }
}