using StationManager.Forms;
using StationManager.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DAO
{
    public class ReportDAO
    {
        public static DataTable GetAllReport()
        {
            return DataProvider.Instance.ExcuteQuery("select * from report");
        }
        public static void AddReport(string title,string content, string file, string employeeId)
        {
            string query = $"insert report(Title,Content,FileUpload,TimeSent,EmployeeId) values (N'{title}',N'{content}','{file}',GETDATE(),'{employeeId}')";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static void EditReport(string id,string title, string content, string file, string employeeId)
        {

            string query = $"update report set title = N'{title}',content = N'{content}',fileupload = '{file}',employeeId = '{employeeId}' where reportId = '{id}'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static void DeleteReport(string id)
        {
            string query = $"delete report where reportId = '{id}'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
