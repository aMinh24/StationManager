﻿using StationManager.DAO;
using StationManager.DTO;
using StationManager.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.CONSTdata;

namespace StationManager.Forms
{
    public partial class PopupPay : Form
    {
        private Bill curBill;
        private Account owner;
        public PopupPay()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public PopupPay(Account owner)
        {
            InitializeComponent();
            this.owner = owner;
        }
        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbAmount.Text))
            {
                MessageBox.Show("Không được nạp 0đ");
                return;
            }
            int amount = int.Parse(txbAmount.Text);
            if (amount < 5000) { MessageBox.Show("Không được nạp dưới 5000đ"); return; }
            curBill = await BillDAO.CreateBill(amount, owner.LoginID);
            Process.Start(new ProcessStartInfo
            {
                FileName = CONST.CHROME,
                Arguments = curBill.link
            });
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            if (curBill == null) { MessageBox.Show("Đang không có giao dịch nào!"); return; }
            string status = await PayService.GetStatusPayment(curBill.id);
            if (status == "PAID")
            {
                AccountDAO.Instance.ChargeAccount(owner.LoginID, owner.balance + curBill.total);
                MessageBox.Show("Nạp thành công");
            }
            else
            {
                MessageBox.Show($"Tình trạng giao dịch: {status}");
            }
        }

        private void txbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (curBill == null) return;
            string status = await PayService.GetStatusPayment(curBill.id);
            if (status == "PAID") return;
            PayService.CancelPayment(curBill.id);
        }

    }
}
