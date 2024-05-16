using TaskManager.Service;
using Meziantou.Framework.Win32;
using StationManager.DAO;
using StationManager.DTO;
namespace StationManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadCredentials();
            lbDangNhap.BackColor = Color.FromArgb(0, 255, 255, 255);
            label1.BackColor = Color.FromArgb(0, 255, 255, 255);
            label2.BackColor = Color.FromArgb(0, 255, 255, 255);
            chbRemember.BackColor = Color.FromArgb(0, 255, 255, 255);
            panel1.BackColor = Color.FromArgb(170, 192, 192, 192);
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public void LoadCredentials()
        {
            txbPassword.PasswordChar = '*';
            cbUsername.DataSource = SavePassword.LoadCredential();
            cbUsername.DisplayMember = "UserName";
            cbUsername.SelectedItem = null;
        }
        private void cbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Credential)cbUsername.SelectedItem == null)
            {
                txbPassword.Text = "";
            }
            else txbPassword.Text = ((Credential)cbUsername.SelectedItem).Password;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account acc = CheckLogin(cbUsername.Text, txbPassword.Text);
            if (acc != null)
            {
                SavePassword.SaveCredential(cbUsername.Text, txbPassword.Text, chbRemember.Checked);
                HomePage home = new HomePage(acc);
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
        }
        private Account CheckLogin(string loginid, string pass)
        {
            return AccountDAO.CheckLogin(loginid, pass);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegAccount regAccount = new RegAccount();
            regAccount.ShowDialog();
        }
    }
}