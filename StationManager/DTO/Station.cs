using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DTO
{
    public class Station
    {
        private bool isChecked;
        private string stationId;
        private string address;
        private int totalPort;
        private int totalActivePort;
        private string status;

        public Station(string stationId, string address, int totalPort, int totalActivePort, string status) 
        {
            this.isChecked = false;
            this.stationId = stationId;
            this.address = address;
            this.totalPort = totalPort;
            this.totalActivePort = totalActivePort;
            this.status = status;
        }

        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public string StationId {get => stationId; set => stationId = value; }
        public string Address { get => address; set => address = value; }
        public int TotalPort { get => totalPort; set => totalPort = value; }
        public int TotalActivePort { get => totalActivePort; set => totalActivePort = value; }
        public string Status { get => status; set => status = value; }
    }
}
