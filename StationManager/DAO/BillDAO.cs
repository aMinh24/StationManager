using StationManager.DTO;
using StationManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DAO
{
    public class BillDAO
    {
        public static int GetNewId()
        {
            string query = "select max(id) from bill";
            int id = (int)DataProvider.Instance.ExcuteScalar(query);
            return id+1;
        }
        public static async Task<Bill> CreateBill(int total,string loginId)
        {
            Task<Bill> t = PayService.GetBillPayment(total);
            await t;
            Bill bill = t.Result;
            Task.Run(() =>
            {
                string query = $"insert bill(total,content,status,loginid) values ('{total}','{DateTime.Now}','{bill.status}','{loginId}')";
                DataProvider.Instance.ExcuteNonQuery(query);
            });
            
            return bill;
        }
    }
}
