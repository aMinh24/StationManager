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
    public partial class AddReport : Form
    {
        bool isEdit = false;
        string id;
        public AddReport()
        {
            InitializeComponent();
            lbTitle.Text = "Thêm Báo Cáo";
            tableLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public AddReport(string id, string title, string content, string file, string employeeId)
        {
            InitializeComponent();
            lbTitle.Text = "Sửa Báo Cáo";
            isEdit = true;
            txbTitle.Text = title;
            txbContent.Text = content;
            txbFile.Text = file;
            txbEmployeeId.Text = employeeId;
            this.id = id;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isEdit)
                AddNewReport(txbTitle.Text, txbContent.Text, txbFile.Text, txbEmployeeId.Text);
            else
                EditReport(id, txbTitle.Text, txbContent.Text, txbFile.Text, txbEmployeeId.Text);
        }
        private void EditReport(string id, string title, string content, string file, string employeeId)
        {
            bool check = true;
            if (string.IsNullOrEmpty(title))
            {
                check = false;
                txbTitle.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txbTitle.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(content))
            {
                check = false;
                txbContent.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txbContent.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(employeeId))
            {
                check |= false;
                txbEmployeeId.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txbEmployeeId.BackColor = Color.White;
            }
            if (check)
            {
                try
                {
                    ReportDAO.EditReport(id, title, content, file, employeeId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sai mã nhân viên");
                }
            }
        }
        private void AddNewReport(string title, string content, string file, string employeeId)
        {
            bool check = true;
            if (string.IsNullOrEmpty(title))
            {
                check = false;
                txbTitle.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txbTitle.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(content))
            {
                check = false;
                txbContent.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txbContent.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(employeeId))
            {
                check |= false;
                txbEmployeeId.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txbEmployeeId.BackColor = Color.White;
            }
            if (check)
            {
                try
                {
                    ReportDAO.AddReport(title, content, file, employeeId);
                    foreach (Control ctr in tableLayoutPanel1.Controls)
                    {
                        if (ctr is TextBox txb)
                            txb.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sai mã nhân viên");
                }
            }

        }
    }
}
