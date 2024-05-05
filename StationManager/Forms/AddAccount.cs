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
    public partial class AddAccount : Form
    {
        List<Account> listEmployeeAccount;
        public AddAccount(List<Account> listEmployeeAccount)
        {
            InitializeComponent();
            this.listEmployeeAccount = listEmployeeAccount;
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string loginID = tbLoginID.Text;
            string password = tbPassword.Text;
            string username = tbUsername.Text;
            string email = tbEmail.Text;
            string empID = tbEmpID.Text;
          
            if (AccountDAO.Instance.createAccount(loginID, password, username, email, empID))
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
            }
        }
    }
}
