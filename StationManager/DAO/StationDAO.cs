using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StationManager.DTO;
using StationManager.Forms;
using StationManager.Service;

namespace StationManager.DAO
{
    public class StationDAO
    {
        public static List<Station> getStationList()
        {
            List<Station> stationList = new List<Station>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM Station");
            foreach (DataRow dr in dt.Rows)
            {
                stationList.Add(new Station(dr["StationId"].ToString(), dr["Address"].ToString(), Convert.ToInt32(dr["TotalPort"]), Convert.ToInt32(dr["TotalActivePort"]), dr["Status"].ToString()));
            }
            return stationList;
        }

        public static void deleteStationById(string stationId)
        {
            string query = "DELETE FROM Station WHERE StationId = @StationId";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { stationId });
        }

        public static void updateStation(string stationId, string address, int totalPort, int totalActivePort, string status)
        {
            string query1 = "UPDATE Station SET Address = @Address WHERE StationId = @StationId";
            string query2 = "UPDATE Station SET TotalPort = @TotalPort WHERE StationId = @StationId";
            string query3 = "UPDATE Station SET TotalActivePort = @TotalActivePort WHERE StationId = @StationId";
            string query4 = "UPDATE Station SET Status = @Status WHERE StationId = @StationId";
            DataProvider.Instance.ExcuteNonQuery(query1, new object[] { address, stationId });
            DataProvider.Instance.ExcuteNonQuery(query2, new object[] { totalPort, stationId });
            DataProvider.Instance.ExcuteNonQuery(query3, new object[] { totalActivePort, stationId });
            DataProvider.Instance.ExcuteNonQuery(query4, new object[] { status, stationId });
        }
    }
}
