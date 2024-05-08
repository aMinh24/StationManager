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
        }
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
