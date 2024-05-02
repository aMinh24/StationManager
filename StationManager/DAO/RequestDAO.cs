using StationManager.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DAO
{
    public class RequestDAO
    {
        private static RequestDAO instance;

        public static RequestDAO Instance
        {

            get
            {
                if (instance == null)
                    instance = new RequestDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private RequestDAO() { }
        public DataTable  GetDataRequest(DateTime timeStart, DateTime timeEnd)
        {
            string query = string.Format("exec ShowRequest '{0}' , '{1}'",timeStart.ToString("MM-dd-yyyy HH:mm:ss"), timeEnd.ToString("MM-dd-yyyy HH:mm:ss"));
            DataTable showWork = DataProvider.Instance.ExcuteQuery(query);
            return showWork;
        }
        public void SendRequest(string title, string content,DateTime timeNow, string userId)
        {
            string query = string.Format("exec AddRequest N'{0}' , N'{1}' , '{2}' , '{3}'",title,content ,timeNow.ToString("MM-dd-yyyy HH:mm:ss"),userId);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
       
        public DataTable RequestNoView()
        {
            string query = " select * from Request where status = N'Chưa xem'";
            return DataProvider.Instance.ExcuteQuery(query);
            
        }
        public void UpdateRequest(string userId)
        {
            string query = string.Format("exec UpdateConfirm '{0}'",userId);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
