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
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { get => instance == null ? new AccountDAO() : instance; set => instance = value; }

        public List<Account> getListUserAccount()
        {
            List<Account> list = new List<Account>();
            string query = "SELECT * FROM Account WHERE Account.LoginId not in (SELECT LoginId from Employee) AND IsDisable = 0";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Account(row));
            }
            return list;
        }
        public List<Account> getListEmployeeAccount()
        {
            List<Account> list = new List<Account>();
            string query = "SELECT Account.*, EmployeeId FROM Account, Employee WHERE Account.LoginId = Employee.LoginId AND IsDisable = 0";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Account(row));
            }
            return list;
        }
        public bool updateAccount(string loginID, string password, string username, string email)
        {
            string query = "UPDATE ACCOUNT SET Password = @Password , Username = @Username , Email = @Email WHERE LoginId = @LoginID";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { password, username, email, loginID }) > 0;
        }
        public bool createAccount(string loginID, string password, string username, string email, string? empID = null)
        {
            string accountQuery = "INSERT INTO Account VALUES ( @loginID , @password , @username , @email , 0 , 0 )";
            string employeeQuery = "INSERT INTO Employee VALUES ( @empID , @loginID )";
            bool accountExecute = DataProvider.Instance.ExcuteNonQuery(accountQuery, new object[] { loginID, password, username, email }) > 0;
            bool employeeExecute = true;
            if (empID != null)
            {
                employeeExecute = DataProvider.Instance.ExcuteNonQuery(employeeQuery, new object[] { empID, loginID }) > 0;
                if (accountExecute == true && employeeExecute == false)
                {
                    DataProvider.Instance.ExcuteNonQuery("DELETE FROM Account WHERE LoginId = @loginID", new object[] { loginID });
                }
            }

            return accountExecute && employeeExecute;
        }
        public bool disableAccount(string loginID)
        {
            string query = "UPDATE ACCOUNT SET IsDisable = 1 WHERE LoginId = @loginID";
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { loginID }) > 0;
        }
        public static Account CheckLogin(string loginID, string password)
        {
            string query = "SELECT Account.*, EmployeeId FROM Account, Employee WHERE Account.LoginId = Employee.LoginId AND IsDisable = 0 and Account.loginId = @loginId and password = @password";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { loginID, password });
            if (dt.Rows.Count > 0)
            {
                return new Account(dt.Rows[0]);
            }
            query = "SELECT * FROM Account WHERE IsDisable = 0 and Account.loginId = @loginId and password = @password";
            dt = DataProvider.Instance.ExcuteQuery(query, new object[] { loginID, password });
            if (dt.Rows.Count > 0)
            {
                return new Account(dt.Rows[0]);
            }
            return null;
        }
        public void ChargeAccount(string loginId, int total)
        {
            string query = $"update account set balance = '{total}' where loginId = '{loginId}'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static string GetRole(string loginId)
        {
            string query = "SELECT Role FROM Account WHERE LoginId = @LoginId";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { loginId });
            return dt.Rows[0]["Role"].ToString();
        }
    }
}