using StationManager.DTO;
using StationManager.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DAO
{
    internal class TaskDAO
    {

        private static TaskDAO instance;

        public static TaskDAO Instance
        {
            get { if (instance == null) instance = new TaskDAO(); return TaskDAO.instance; }
            private set { TaskDAO.instance = value; }
        }
        public List<CongViec> getTaskList()
        {
            List<CongViec> list = new List<CongViec>();

            string query = "SELECT * FROM TASK";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CongViec task = new CongViec(item);
                list.Add(task);
            }
            return list;
        }

        public bool InsertTask(string maNV, string maCV, string tieuDe, string noiDung, DateTime batDau, DateTime ketThuc)
        {
            string query = String.Format("INSERT INTO TASK VALUES ('N{0}', N'{1}', '{2}', '{3}', '{4}', '{5}');", tieuDe, noiDung, maCV, batDau, ketThuc, maNV);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTask(string maNV, string maCV, string tieuDe, string noiDung, DateTime batDau, DateTime ketThuc)
        {
            string query = String.Format("UPDATE TASK SET Title = N'{0}', Content = N'{1}', TimeStart = '{3}', TimeEnd = '{4}', EmployeeId ='{5}' WHERE TaskId ='{2}';", tieuDe, noiDung, maCV, batDau, ketThuc, maNV);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTask(string maCV)
        {
            string query = String.Format("DELETE FROM TASK WHERE TaskId = '{0}'", maCV);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}