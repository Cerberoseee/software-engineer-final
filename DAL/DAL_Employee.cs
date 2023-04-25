using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Employee
    {
        DTO_Employee emp;

        public static string passwordHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public DAL_Employee(string employeeid, string employeename, string employeerole, string username, string password) 
        {
            emp = new DTO_Employee(employeeid, employeename, employeerole, username, password);
        }

        public void addQuery()
        {
            string sql = "insert into Employee values (" +
                "'" + emp._EMPLOYEEID + "', " +
                "'" + emp._EMPLOYEENAME + "', " +
                "'" + emp._EMPLOYEEROLE + "', " +
                "'" + emp._USERNAME + "', " +
                "'" + passwordHash(emp._PASSWORD) + "'" +
                ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "update Employee set " +
                "EmployeeName = '" + emp._EMPLOYEEID + "', " +
                "EmployeeRole = '" + emp._EMPLOYEEROLE + "', " +
                "Username = '" + emp._USERNAME + "', " +
                "Password = '" + passwordHash(emp._PASSWORD) + "' " +
                "where EmployeeID = '" + emp._EMPLOYEEID + "'";
            Connection.actionQuery(sql);
        }

        public void removeQuery()
        {
            string sql = "delete from Employee where EmployeeID = '" + emp._EMPLOYEEID + "'";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "select * from Employee";
            return Connection.selectQuery(sql);
        }
    }
}
