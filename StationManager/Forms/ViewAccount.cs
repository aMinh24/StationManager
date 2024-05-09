using StationManager.DAO;
using StationManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationManager.Forms
{
    public partial class ViewAccount : Form
    {
        List<Account> listEmployeeAccount;
        List<Account> listUserAccount;
        public ViewAccount()
        {
            InitializeComponent();
            listEmployeeAccount = AccountDAO.Instance.getListEmployeeAccount();
            listUserAccount = AccountDAO.Instance.getListUserAccount();
            cbPhanLoai.SelectedIndex = 0;
            LoadInforBinding();
            RegAccount reg = new RegAccount();
            reg.Show();
        }
        private void BindingControl(Control control, string datamember)
        {
            control.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, datamember, true, DataSourceUpdateMode.Never));
        }
        private void LoadInforBinding()
        {
            ClearAllBinding();
            BindingControl(tbLoginID, "loginID");
            BindingControl(tbPassword, "Password");
            BindingControl(tbUsername, "Username");
            BindingControl(tbEmail, "Email");
            BindingControl(tbEmpID, "EmpID");

        }
        private void ClearAllBinding()
        {
            ClearBinding(tbLoginID);
            ClearBinding(tbPassword);
            ClearBinding(tbUsername);
            ClearBinding(tbEmail);
            ClearBinding(tbEmpID);
        }
        private void refreshListAccount()
        {
            listEmployeeAccount = AccountDAO.Instance.getListEmployeeAccount();
            listUserAccount = AccountDAO.Instance.getListUserAccount();
        }
        private void ClearBinding(Control control)
        {
            control.DataBindings.Clear();
        }
        public void loadUserAccount()
        {
            dtgvAccount.DataSource = listUserAccount;
        }
        public void loadEmployeeAccount()
        {
            dtgvAccount.DataSource = listEmployeeAccount;
        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhanLoai.SelectedIndex == 0)
            {
                ClearAllBinding();
                dtgvAccount.Columns["EmpID"].Visible = false;
                loadUserAccount();
                LoadInforBinding();
            }
            else if (cbPhanLoai.SelectedIndex == 1)
            {
                ClearAllBinding();
                dtgvAccount.Columns["EmpID"].Visible = true;
                loadEmployeeAccount();
                LoadInforBinding();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string loginID = tbLoginID.Text;
            string password = tbPassword.Text;
            string username = tbUsername.Text;
            string email = tbEmail.Text;
            if (listEmployeeAccount.Concat(listUserAccount).Where(account => account.LoginID != loginID).Any(account => account.Email.Equals(email))) { MessageBox.Show("Email đã tồn tại!"); return; }
            bool isSucceed = AccountDAO.Instance.updateAccount(loginID, password, username, email);
            if (isSucceed)
            {
                MessageBox.Show("Cập nhật thành công");
                refreshListAccount();
                cbPhanLoai_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddAccount addAccount = new AddAccount(listEmployeeAccount.Concat(listUserAccount).ToList()))
            {
                addAccount.ShowDialog();
                this.listEmployeeAccount = AccountDAO.Instance.getListEmployeeAccount();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string loginID = tbLoginID.Text;
            bool isDisable = AccountDAO.Instance.disableAccount(loginID);
            if (isDisable)
            { MessageBox.Show("Vô hiệu tài khoản thành công"); refreshListAccount(); cbPhanLoai_SelectedIndexChanged(sender, e); }
            else
            { MessageBox.Show("Vô hiệu tài khoản thất bại"); }
        }
    }
}