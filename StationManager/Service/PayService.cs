
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.payOS;
using Net.payOS.Types;
using StationManager.DAO;
using StationManager.DTO;
namespace StationManager.Service
{
    public class PayService
    {
        private static string clientId = "531e5f5c-bb6d-49e7-91bf-c48c6b195726";
        private static string apiKey = "9cda7cf6-2eae-4674-9379-a7fb106b94af";
        private static string checksumKey = "7e4e7b6a222bdec60378fab793c4c49ca9295f2b0ed1485cdd082df6590dc55e";
        private static PayOS payOS = new PayOS(clientId, apiKey, checksumKey);
        public static async Task<Bill> GetBillPayment(int total)
        {
            var name = $"Nạp tài khoản {total}";
            var soluong = 1;
            var thanhtien = total;

            ItemData item = new ItemData(name, soluong, thanhtien);
            List<ItemData> items = new List<ItemData>();
            items.Add(item);

            var noidung = "Thanh toán tiền nạp";
            var orderID = BillDAO.GetNewId();
            var tongGiaTien = total; // 2 ngàn vnđ

            PaymentData paymentData = new PaymentData(orderID, tongGiaTien, noidung,
                 items, "https://www.youtube.com/watch?v=dQw4w9WgXcQ", "https://www.youtube.com/watch?v=dQw4w9WgXcQ");

            CreatePaymentResult createPayment = await payOS.createPaymentLink(paymentData);
            return new Bill(orderID, total, createPayment.checkoutUrl, createPayment.status);
        }
        public static async Task<string> GetStatusPayment(int id)
        {
            Task<PaymentLinkInformation> t = payOS.getPaymentLinkInfomation(id);
            await t;
            PaymentLinkInformation paymentLinkInfomation = t.Result;
            return paymentLinkInfomation.status;
        }
        public static async void CancelPayment(int id)
        {
            try
            {
                PaymentLinkInformation cancelledPaymentLinkInfo = await payOS.cancelPaymentLink(id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
