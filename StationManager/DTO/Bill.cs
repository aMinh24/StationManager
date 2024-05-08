using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DTO
{
    public class Bill
    {
        public int id;
        public int total;
        public string link;
        public string status;

        public Bill(int id, int total, string link, string status)
        {
            this.id = id;
            this.link = link;
            this.status = status;
            this.total = total;
        }
    }
}
