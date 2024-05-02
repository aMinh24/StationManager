using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DTO
{
    public class Request
    {
        public string requestId;
        public string title;
        public string content;
        public DateTime timeSent;
        public string status;
        public string loginId;

        public Request(DataRow row)
        {
            this.requestId = (string)row["requestId"];
            this.title = (string)row["title"];
            this.content = (string)row["content"];
            this.status = (string)row["status"];
            this.timeSent = (DateTime)row["timeSent"];
            this.loginId = (string)row["loginId"];
        }

        public Request(string id, string title, string content,DateTime timeSent,string status ,string loginId)
        {
            this.requestId = id;
            this.title = title;
            this.content = content;
            this.timeSent=timeSent;
            this.status = status;
            this.loginId = loginId;
        }
    }
}
