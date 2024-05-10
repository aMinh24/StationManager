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
        public HomePage(Account acc)
        {
            InitializeComponent();
            this.owner = acc;
            lbBalance.Text = $"{owner.balance} VNĐ";
            panel1.BackColor = Color.FromArgb(128, 192, 192, 192);
            label1 .BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ViewAccount viewAccount = new ViewAccount();
            viewAccount.Show();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            ViewStation viewStation = new ViewStation();
            viewStation.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            ViewRequest viewRequest = new ViewRequest();
            viewRequest.Show();
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