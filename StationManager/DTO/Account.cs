using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationManager.DTO
{
    public class Account
    {
        private string loginID;
        private string password;
        private string username;
        private string email;
        private string empID;
        public int balance;

        public string LoginID { get => loginID; set => loginID = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string EmpID { get => empID; set => empID = value; }

        public Account(DataRow row)
        {
            loginID = row["LoginId"].ToString();
            password = row["Password"].ToString();
            username = row["Username"].ToString();
            email = row["Email"].ToString();
            balance = int.Parse(row["balance"].ToString());
            try
            {
                EmpID = row["EmployeeId"].ToString();
            }
            catch (Exception) { EmpID = null; }

        }
    }
}