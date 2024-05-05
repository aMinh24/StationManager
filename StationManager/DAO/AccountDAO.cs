﻿using StationManager.DTO;
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
            string query = "SELECT * FROM Account WHERE Account.LoginId not in (SELECT LoginId from Employee)";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in table.Rows)
            {
                list.Add(new Account(row));
            }
            return list;
        }
        public List<Account> getListEmployeeAccount()
        {
            List<Account> list = new List<Account>();
            string query = "SELECT Account.*, EmployeeId FROM Account, Employee WHERE Account.LoginId = Employee.LoginId";
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
            return DataProvider.Instance.ExcuteNonQuery(query, new object[] {password, username, email, loginID}) > 0;
        }
        public bool createAccount(string loginID, string password, string username, string email, string empID)
        {
            string accountQuery = "INSERT INTO Account VALUES ( @loginID , @password , @username , @email )";
            string employeeQuery = "INSERT INTO Employee VALUES ( @empID , @loginID )";
            bool accountExecute = DataProvider.Instance.ExcuteNonQuery(accountQuery, new object[] { loginID, password, username, email }) > 0;
            bool employeeExecute = DataProvider.Instance.ExcuteNonQuery(employeeQuery, new object[] { empID,  loginID }) > 0;
            if(accountExecute == true && employeeExecute == false)
            {
                DataProvider.Instance.ExcuteNonQuery("DELETE FROM Account WHERE LoginId = @loginID", new object[] { loginID } );
            }
            return accountExecute && employeeExecute;
        }
    }
}