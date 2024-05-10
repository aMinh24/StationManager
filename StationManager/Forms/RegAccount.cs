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
    public partial class RegAccount : Form
    {
        List<Account> listAccountCombined = AccountDAO.Instance.getListUserAccount().Concat(AccountDAO.Instance.getListEmployeeAccount()).ToList();
        public RegAccount()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string loginID = tbLoginID.Text;
            string password = tbPassword.Text;
            string username = tbUsername.Text;
            string email = tbEmail.Text;
            if (listAccountCombined.Any(account => account.LoginID.Equals(loginID))) { MessageBox.Show("Login ID đã tồn tại"); return; }
            if (listAccountCombined.Any(account => account.Email.Equals(email))) { MessageBox.Show("Email đã tồn tại"); return; }
            if (AccountDAO.Instance.createAccount(loginID, password, username, email))
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }
    }
}
