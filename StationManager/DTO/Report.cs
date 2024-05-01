using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DTO
{
    public class Report
    {
        public string id;
        public string title;
        public string content;
        public string file;
        public DateTime timesent;
        public string employeeId;

        public Report(DataRow row)
        {
            this.id = (string)row["id"];
            this.title = (string)row["title"];
            this.content = (string)row["content"];
            this.file= (string)row["file"];
            this.timesent = (DateTime)row["timesent"];
            this.employeeId = (string)row["employeeId"];
        }

        public Report(string id, string title, string content, string file, DateTime timesent, string employeeId)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.file = file;
            this.timesent = timesent;
            this.employeeId = employeeId;
        }
    }
}
