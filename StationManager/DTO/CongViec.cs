using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DTO
{
    internal class CongViec
    {
        private String taskID;
        private String employeeID;
        private String taskTitle;
        private String taskDescription;
        private DateTime taskStart;
        private DateTime taskEnd;

        public string TaskID { get => taskID; set => taskID = value; }
        public string TaskTitle { get => taskTitle; set => taskTitle = value; }
        public string TaskDescription { get => taskDescription; set => taskDescription = value; }
        public DateTime TaskStart { get => taskStart; set => taskStart = value; }
        public DateTime TaskEnd { get => taskEnd; set => taskEnd = value; }
        public string EmployeeID { get => this.employeeID; set => this.employeeID = value; }

        public CongViec(string taskID, string employeeID, string taskTitle, string taskDescription, DateTime taskStart, DateTime taskEnd)
        {
            this.taskID = taskID;
            this.employeeID = employeeID;
            this.taskTitle = taskTitle;
            this.taskDescription = taskDescription;
            this.taskStart = taskStart;
            this.taskEnd = taskEnd;
        }

        public CongViec(DataRow row)
        {
            this.taskID = (string)row["TaskId"];
            this.employeeID = (string) row["EmployeeId"];
            this.taskTitle = (string)row["Title"];
            this.TaskDescription = (string)row["Content"];
            this.taskStart = (DateTime)row["TimeStart"];
            this.taskEnd = (DateTime)row["TimeEnd"];
        }
    }
}
